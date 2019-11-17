using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using ContosoUniversity.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Controllers
{
    public class TopicController : Controller
    {
        private readonly SchoolContext _context;

        public TopicController(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var topicsViewModel = new TopicsViewModel();
            var topics= await _context.Topic.Select(o => o).ToListAsync();

            foreach (var topicItem in topics)
            {
                var tmpTopicViewModel = new TopicViewModel
                {
                    TopicId = topicItem.TopicId,
                    PostCount = topicItem.PostCount,
                    Title = topicItem.Title,
                    OriginalPoster = topicItem.OriginalPoster
                };
                var posts = await _context.Post
                    .Where(o => o.TopicId == topicItem.TopicId)
                    .Select(u =>
                    new PostViewModel { 
                        Poster =u.Poster,
                        Body = u.Body,
                        TimeStamp = u.TimeStamp
                    }).ToListAsync();

                tmpTopicViewModel.Posts = posts;

                topicsViewModel.Topics.Add(tmpTopicViewModel);
            }

            return View(topicsViewModel);
        }

        public async Task<IActionResult> CreateTopic()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTopic(TopicViewModel model)
        {
            var topic = new Topic
            {
                Title = model.Title,
                OriginalPoster = model.OriginalPoster,
                PostCount = model.PostCount
            };
            await _context.AddAsync(topic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CreatePost(int id)
        {
            var postViewModel = new PostViewModel
            {
                TopicId = id
            };
            return View(postViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(PostViewModel model)
        {
            var post = new Post
            {
                TopicId = model.TopicId,
                TimeStamp = model.TimeStamp,
                Poster = model.Poster,
                Body = model.Body
            };
            await _context.AddAsync(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}