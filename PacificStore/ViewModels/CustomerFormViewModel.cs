using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using PacificStore.Models;

namespace PacificStore.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}