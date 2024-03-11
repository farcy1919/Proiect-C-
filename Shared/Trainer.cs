using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp_empty1.Shared
{
    public class Trainer
    {
        public int ID {  get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public int Age {  get; set; }
        public int Matches {  get; set; }
        public int KO {  get; set; }

        public string ImgSrc { get; set; }
        public string Details { get; set; }    

        public string Description { get; set; }
    }
    
}
