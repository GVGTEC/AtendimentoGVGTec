using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL.Contexto;
using DAL.MODEL;

namespace WEB
{
    public class AtendimentoesController : Controller
    {
        private BancoContexto db = new BancoContexto();

        // GET: Atendimentoes
        public ActionResult Index()
        {
            var atendimentoCtx = db.AtendimentoCtx.Include(a => a.ClienteX);
            return View(atendimentoCtx.ToList());
        }

        // GET: Atendimentoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atendimento atendimento = db.AtendimentoCtx.Find(id);
            if (atendimento == null)
            {
                return HttpNotFound();
            }
            return View(atendimento);
        }

        // GET: Atendimentoes/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(db.ClienteCtx, "Id", "Nome");
            return View();
        }

        // POST: Atendimentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Data,NomeSolicitante,Descricao,Observacao,CobrarServico,ValorServico,TempoServico,ClienteId")] Atendimento atendimento)
        {
            if (ModelState.IsValid)
            {
                db.AtendimentoCtx.Add(atendimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(db.ClienteCtx, "Id", "Nome", atendimento.ClienteId);
            return View(atendimento);
        }

        // GET: Atendimentoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atendimento atendimento = db.AtendimentoCtx.Find(id);
            if (atendimento == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = new SelectList(db.ClienteCtx, "Id", "Nome", atendimento.ClienteId);
            return View(atendimento);
        }

        // POST: Atendimentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Data,NomeSolicitante,Descricao,Observacao,CobrarServico,ValorServico,TempoServico,ClienteId")] Atendimento atendimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atendimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(db.ClienteCtx, "Id", "Nome", atendimento.ClienteId);
            return View(atendimento);
        }

        // GET: Atendimentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atendimento atendimento = db.AtendimentoCtx.Find(id);
            if (atendimento == null)
            {
                return HttpNotFound();
            }
            return View(atendimento);
        }

        // POST: Atendimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Atendimento atendimento = db.AtendimentoCtx.Find(id);
            db.AtendimentoCtx.Remove(atendimento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
