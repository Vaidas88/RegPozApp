using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegPozApp.Models;
using RegPozApp.Repositories;
using System.Collections.Generic;

namespace RegPozApp.Controllers
{
    public class QuestionController : Controller
    {
        private readonly QuestionRepository _questionRepository;
        private readonly FormRepository _formRepository;

        public QuestionController(QuestionRepository questionRepository, FormRepository formRepository)
        {
            _questionRepository = questionRepository;
            _formRepository = formRepository;
        }

        public ActionResult Index()
        {
            var forms = _formRepository.GetAll();

            return View(forms);
        }

        public ActionResult SingleForm(int id)
        {
            var questions = _questionRepository.GetAllByFormId(id);

            return View(questions);
        }

        public ActionResult Edit()
        {
            return View(nameof(Index));
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
    }
}
