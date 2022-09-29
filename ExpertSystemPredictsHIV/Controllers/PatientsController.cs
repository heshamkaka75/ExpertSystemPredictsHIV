using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertSystemPredictsHIV.Data;
using ExpertSystemPredictsHIV.Models;

namespace ExpertSystemPredictsHIV.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Patients
        public async Task<IActionResult> Index()
        {
            var IsLoging = User.Identity.IsAuthenticated;
            var IsAdmin = User.Identity.Name;

            if (IsLoging == false)
            {
                return LocalRedirect("~/identity/Account/Login");
            }

            if (IsAdmin != "admin@hiv.com")
            {
                return RedirectToAction("Index", "Home");
            }

            return View(await _context.Patients.ToListAsync());
        }

        // GET: Patients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // GET: Patients/Create
        public IActionResult Create()
        {
            var IsLoging = User.Identity.IsAuthenticated;

            if (IsLoging == false)
            {
                return LocalRedirect("~/identity/Account/Login");
            }

            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age,Gender,MaritalStatus,Fever,Headache,Diarrhea,WeightLoss,Cough,NightSweats,Musclepain,Constant,SkinRash,SorePainfulMouthUlcers,SwollenLymphNodes,WhiteSpotsOnTongue,RashOrBlisters,UlcerationInTheMouthOrGenitals,SexualIntercourse,SharingNeedles,Transfusion,BloodPressure,Diabetes,HeartDisease,KidneyDisease,StomachDisease,Total")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                #region Total Logec
                patient.Total = (patient.Fever == 0 ? 0 : 3) + (patient.Headache == 0 ? 0 : 3) + (patient.Diarrhea == 0 ? 0 : 5) +
                    (patient.WeightLoss == 0 ? 0 : 5) + (patient.Cough == 0 ? 0 : 5) + (patient.NightSweats == 0 ? 0 : 5) +
                    (patient.Musclepain == 0 ? 0 : 5) + (patient.Constant == 0 ? 0 : 5) + (patient.SkinRash == 0 ? 0 : 5) +
                    (patient.SorePainfulMouthUlcers == 0 ? 0 : 5) + (patient.SwollenLymphNodes == 0 ? 0 : 5) +
                    (patient.WhiteSpotsOnTongue == 0 ? 0 : 5) + (patient.RashOrBlisters == 0 ? 0 : 5) +
                    (patient.UlcerationInTheMouthOrGenitals == 0 ? 0 : 5) + (patient.SexualIntercourse == 0 ? 0 : 8) +
                    (patient.SharingNeedles == 0 ? 0 : 8) + (patient.Transfusion == 0 ? 0 : 8) +
                    (patient.BloodPressure == 0 ? 0 : 2) + (patient.Diabetes == 0 ? 0 : 2) + (patient.HeartDisease == 0 ? 0 : 2) +
                    (patient.KidneyDisease == 0 ? 0 : 2) + (patient.StomachDisease == 0 ? 0 : 2);
                #endregion

                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Patients", new { id = patient.Id });
            }
            return View(patient);
        }

        // GET: Patients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age,Gender,MaritalStatus,Fever,Headache,Diarrhea,WeightLoss,Cough,NightSweats,Musclepain,Constant,SkinRash,SorePainfulMouthUlcers,SwollenLymphNodes,WhiteSpotsOnTongue,RashOrBlisters,UlcerationInTheMouthOrGenitals,SexualIntercourse,SharingNeedles,Transfusion,BloodPressure,Diabetes,HeartDisease,KidneyDisease,StomachDisease,Total")] Patient patient)
        {
            if (id != patient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientExists(patient.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Patients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientExists(int id)
        {
            return _context.Patients.Any(e => e.Id == id);
        }
    }
}
