﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using BrokerTools.Data.Model;
using System.Collections.Generic;

namespace BrokerTools.Data.Controller
{
    public class AdvisorController
    {
        public static IEnumerable<Advisor> GetAllAdvisors()
        {
            using (AdvisorRepository db = new AdvisorRepository())
            {
                return db.GetAllAdvisors();
            }
        }
    }
}
