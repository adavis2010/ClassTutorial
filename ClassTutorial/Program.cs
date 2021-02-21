using System;

namespace ClassTutorial {
    class Program {
        static
            void Main(string[] args) {




            // While Statement Assignment slide 101
            var nbr = 1;
            if (nbr % 2 != 0)
                Console.WriteLine("odd numbers");

            /*    while (nbr <= 25) {
                    var cubed = nbr * nbr * nbr;
                    Console.WriteLine($"{cubed}");
                    nbr += 2;
                }
            */


            // Ternary Class Assignment Slide 108

            for (var idx = 1; idx <= 30; idx++) {
                if (idx % 3 == 0 && idx % 5 == 0) {
                    Console.WriteLine("FIZZBUZZ");

                } else {
                    if (idx % 3 == 0)

                        Console.WriteLine("FIZZ");
                    else {
                        if (idx % 5 == 0) {

                            Console.WriteLine("BUZZ");

                        } else {
                            Console.WriteLine($"{idx}");
                        }
                    }
                }



                /*
                            //Ternary statement

                            var trafficlight = "red";
                             var command = (trafficlight =="red") ? "Stop" : "Go";
                                Console.WriteLine($"The sign says {command}");




                            //           var statecode = "OH";
                            //      New Switch Statement line 10- 16
                            //
                            //         var statename = statecode switch {
                            //             "OH" => "Ohio",
                            //              "KY" => "Kentucky",
                            //               "IN" => "Indiana",
                            //              _ => "Not found"
                            //           };

                            //Ternary statement slide 108



                            /*

                            var statecode = "OH";
                            var statename = "";
                            switch (statecode) {
                                case "IN":
                                    statename = "Indiana";
                                    break;
                                case "KY":
                                    statename = "Kentucky";
                                    break;
                                case "OH":
                                    statename = "Ohio";
                                    break;
                                default:
                                    statename = "Not Found";
                                    break;
                            }
                                    Console.WriteLine($"statecode is {statecode}, name is {statename}");
                            */




                /* var count = 1;

                 while (count <= 25) {
                     if (count % 2 != 0) {


                         Console.WriteLine($"the number is {count * count * count}");
                     }
                     count++;
                 }
     */

                // Add up numbers 1-50 that are evenly divisible by 5 or 7 slide 91

                //var total = 0;
                //for (var idx = 0; idx <= 50; idx++) {
                    // if (idx % 5 == 0) {


                    //  }

              //  }

               // Console.WriteLine($"Total is {total}");











                /*

                var thriller = new Song() {
                        Title = "Thriller",
                        Artist = "Michael Jackson",
                        Genre = "Pop",
                        Released = new DateTime(1984, 6, 1),
                        Platinum = true

                    };

                    var thunderstruck = new Song {
                        Title = "Thunderstruck",
                        Artist = "AC/DC",
                        Genre = "Rock",
                        Released = new DateTime(1973, 1, 1),
                        Platinum = true

                    };

                    var amazinggrace = new Song {
                        Title = "Amazing Grace",
                        Artist = "Jesus",
                        Genre = "Gospel",
                        Released = new DateTime(1901, 9, 23),
                        Platinum = true
                    };

                    var takemehometonight = new Song {
                        Title = "Take Me Home Tonight",
                        Artist = "Eddie Money",
                        Genre = "Rock",
                        Released = new DateTime(1986, 4, 22),
                        Platinum = false

                    };


                    var dreamon = new Song {
                        Title = "Dream On",
                        Artist = "Aerosmith",
                        Genre = "Rock",
                        Released = new DateTime(1973, 6, 27),
                        Platinum = true
                    };

                var waymaker = new Song {
                    Title = "Waymaker",
                    Artist = "Michael W. Smith",
                    Genre = "Gospel",
                    Released = new DateTime(2020, 2, 1),
                    Platinum = false


                };

                    var wastedOntheWay = new Song {
                        Title = "Wasted on the Way",
                        Artist = "Crosby, Stills and Nash",
                        Genre = "Pop",
                        Released = new DateTime(1982, 12, 31),
                        Platinum = false

                    };





                var songs = new Song[] {thriller,thunderstruck,amazinggrace,dreamon,takemehometonight, waymaker, wastedOntheWay };
                      foreach (var song in songs) {
                         if (song.Platinum == false) {


                            Console.WriteLine($"{song.Title}");
                          }
                      }

                */







                //var x = 7;
                //if (x == 5) {
                //    Console.WriteLine("x is 7");

                //} else {
                //    Console.WriteLine("x is NOT 7)");
                //}







                // var Math = new Major {
                //            Description = "Math", MinSAT = 1200

                //        };

                //        var Science = new Major {
                //            Description = "Science", MinSAT = 1100

                //        };
                //        Math.Print();
                //       // Science.Print();

                //        //Start Arrays
                
                var ints1 = new[] { 20, 49, 94, 91, 64, 92, 26, 37, 45, 49 };
               var ints2 = new[] { 611, 589, 466, 792, 876, 752, 270, 166, 357 };
                //var ints3 = new[] { 2155, 5622, 2974, 2563, 8201, 6627, 3380, 2551 };

                var sum = 0;
                foreach (var item in ints2) {
                    if (item % 3 == 0)
                        {
                        sum += item;
                    }



                }
                Console.WriteLine($"Sum is {sum}");
                





                //for (var idx = 0; idx < ints1.Length; idx++) {
                //    Console.WriteLine("idx is {idx} and ints [idx] is {ints1[idx]}");
                //}
                //use length of all properties
                //for (var idx = 0; idx < ints2.Length; idx++) {
                //    Console.WriteLine($"idx is {idx} and ints[idx] is{ints2[idx]}");

                //}
                //sum all the numbers in the collection(ARRAYS)
                           // var total3 = 0;
                           // for (var idx = 0; idx < ints3.Length; idx++) {

                             //   if (ints3[idx] % 2 == 0) {
                               //     total3 = total3 + ints3[idx];
                              // }

                         //  }

                //            Console.WriteLine($"Total3 of ints3 is {total3}");

                //            //sum all numbers in the first array
                //            var total4 = 0;
                //            for (var idx = 0; idx < ints1.Length; idx++) {
                //                total4 = total4 + ints1[idx];
                //            }
                //            Console.WriteLine($"Total4 of ints4 is {total4}");

                //            //sum all numbers in second array

                //            var total2 = 0;
                //            for (var idx = 0; idx < ints3.Length; idx++) {
                //                total2 = total2 + ints3[idx];
                //            }

                //            Console.WriteLine($"Total2 of ints3 is {total2}");


                //            //Console.WriteLine($"Total2 of ints3 is {total2}");
                //        }
                //    }
                //}

                //Finish Arrays

                //        var dustin = new Student("dustin");
                //        //dustin.Name = "Dustin";
                //        dustin.Address = "4900 Parkway Dr.";
                //        dustin.GPA = 4.1m;
                //        dustin.Major = "Under Water and Above Water Basket Weaving";
                //        dustin.HasGraduated();
                //        dustin.NewGPA(4.2m);

                //        dustin.Print();

                //        var ucName = dustin.UppercaseName();
                //        Console.WriteLine($"ucName is {ucName}");


                //        var jonathan = new Student {
                //            Name = "Jonathan",
                //            Address = "4900 Parkway Dr.",
                //            GPA = 4.0m,
                //            Major = " Above Water Basket Weaving"

                //        };
                //        jonathan.Name = "Jonathan";
                //        jonathan.Address = "4900 Parkway Dr.";
                //        jonathan.GPA = 4.0m;
                //        jonathan.Major = "Above Water Basket Weaving";

                //        jonathan.Print();

                /*   var Pete = new Student {
                       Name = "Pete",
                       Address = "4900 Parkway Dr.",
                       GPA = 3.9m,
                       Major = "Basket Weaving"
                   };
                   Pete.Name = "Pete";
                   Pete.Address = "4900 Parkway Dr.";
                   Pete.GPA = 3.9m;
                   Pete.Major = "Basket Weaving";

                   Pete.Print();
                */








                //        var andrea = new Student {
                //            Name = "Andrea",
                //            Address = "4900 Parkway Dr.",
                //            GPA = 4.0m,
                //            Major = " Under Water Basket Weaving"
                //        };


                //        andrea.Print();
            }
        }
    }
}





