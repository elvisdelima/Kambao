	﻿using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	using Kambao.Data;
	using Restfulie.Server.Results;
	
	namespace Kambao.Controllers
	{
	    public abstract class CrudController<T> : Controller where T : class
	    {
	        protected readonly CrudData<T> Data;
	
	        protected CrudController()
	        {
	
	        }
	
	        protected CrudController(CrudData<T> data)
	        {
	            this.Data = data;
	        }
	
	        [HttpGet]
	        public virtual ActionResult Index()
	        {
	            return new OK(Data.List());
	        }
	
	        [HttpGet]
	        public virtual ActionResult Create()
	        {
                return new OK();
	        }
	
	        [HttpGet]
	        public virtual ActionResult Edit(int id)
	        {
	            var DataObj = Data.Get(id);
	
	            if (DataObj == null)
	                return new NotFound();
                
	            return new OK(Data.Get(id));
	        }
	
	        [HttpPost]
	        public virtual ActionResult Create(T entidade)
	        {
                Data.Save(entidade);
                return RedirectToAction("Index");
	        }
	
	        [HttpPost]
	        public virtual ActionResult Edit(T entidade)
	        {
                Data.Update(entidade);
                return RedirectToAction("Index");
	        }
	
	        [HttpGet]
	        public virtual ActionResult Delete(int id)
	        {
	            var DataObj = Data.Get(id);
	            Data.Delete(DataObj);
	            return RedirectToAction("Index");
	        }
	    }
	}
