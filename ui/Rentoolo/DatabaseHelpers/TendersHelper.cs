﻿using Rentoolo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentoolo.DatabaseHelpers
{
    public static class TendersHelper
    {
        public static void CreateTender(Tenders tender)
        {
            using (var dc = new RentooloEntities())
            {
                dc.Tenders.Add(tender);
                dc.SaveChanges();
            }
        }


        public static TenderRequest GetTenderRequest(int id)
        {
            using (var dc = new RentooloEntities())
            {
                var tenderRequest = dc.TenderRequest.First(x => x.Id == id);
                return tenderRequest;
            }
        }

        public static List<Tenders> GetAllTenders()
        {
            using(var dc = new RentooloEntities())
            {
                List<Tenders> tenders = dc.Tenders.Select(x => x).ToList();
                return tenders;
            }
        } 

        public static Tenders GetTenderById(int id)
        {
            using (var dc = new RentooloEntities())
            {
                Tenders tender = dc.Tenders.Where(x => x.Id == id).First();
                return tender;
            }
        }

        public static List<Tenders> GetTenders(string name)
        {
            using (var dc = new RentooloEntities())
            {
                var tenders = from t in dc.Tenders where t.Name.Contains(name) select t;
                return tenders.ToList();
            }
        }

        public static void CreateTenderRequest(TenderRequest request)
        {
            using (var dc = new RentooloEntities())
            {
                dc.TenderRequest.Add(request);
                dc.SaveChanges();
            }
        }


        public static List<TenderRequest> GetTenderRequests(int id)
        {
            using (var dc = new RentooloEntities())
            {
                var trequests = dc.TenderRequest.Where(x => x.TenderId == id).ToList();
                return trequests;
            }
        }





    }
}