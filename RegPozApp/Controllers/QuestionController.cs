﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegPozApp.Models;
using RegPozApp.Repositories;
using System.Collections.Generic;

namespace RegPozApp.Controllers
{
    public class QuestionController : Controller
    {
        private QuestionRepository _questionRepository;

        public QuestionController(QuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        // GET: QuestionController
        public ActionResult Index(int id)
        {
            if (id == 0)
            {

            }
            var questions = _questionRepository.GetAllByFormId(id);

            return View(questions);
        }

        // GET: QuestionController/Details/5
        public ActionResult SingleForm(int id)
        {
            return View();
        }

        // GET: QuestionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(List<Question> questions)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            foreach (Question question in questions)
            {
                var questionToUpdate = _questionRepository.Get(question.Id);
                questionToUpdate.AnswerId = question.AnswerId;
                _questionRepository.Update(questionToUpdate);
            }

            _questionRepository.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
