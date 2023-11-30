﻿using ASP.NET_MVC.Models;
using ASP.NET_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETSchool.Controllers {
    public class SubjectsController : Controller {
        public SubjectService service;

        public SubjectsController(SubjectService subjectService) {
            this.service = subjectService;
        }
        public async Task<IActionResult> IndexAsync() {
            var allSubjects = await service.GetAllAsync();
            return View(allSubjects);
        }
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Subject subject) {
            await service.CreateSubjectAsync(subject);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id) {
            var subjectToEdit = await service.GetById(id);
            if (subjectToEdit == null) {
                return View("NotFound");
            }
            return View(subjectToEdit);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name")] Subject subject) {
            await service.UpdateAsync(subject);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int id) {
            var subjectToDelete = await service.GetById(id);
            if (subjectToDelete == null) {
                return View("NotFound");
            }
            await service.DeleteAsync(subjectToDelete);
            return RedirectToAction("Index");
        }
    }
}