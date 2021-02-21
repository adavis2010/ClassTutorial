using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTutorial {
 
    class Major {
        public int Id { get; set; }
        private static int NextId { get; set; } = 1;
        public string Description { get; set; }
        public int MinSAT { get; set; }

        public void Print() {
            Console.WriteLine($" {Id} |{Description} | {MinSAT}");


        }

        public Major() {
            Id = NextId;
            NextId = NextId + 1;
        }

        }

            
        

    }
    


