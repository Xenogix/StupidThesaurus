using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesaurusFinder.Models;

namespace ThesaurusFinder.Controllers
{
    public class DefaultController
    {
        private DefaultView myView;
        private DefaultModel myModel;

        public DefaultController(DefaultView myView, DefaultModel myModel)
        {
            this.myView = myView;
            this.myModel = myModel;

            myView.myController = this;
        }
    }
}
