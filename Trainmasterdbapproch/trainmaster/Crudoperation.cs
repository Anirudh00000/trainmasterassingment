using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace trainmaster.Models
{
    public class Crudoperation
    {
        TrainmasterContext trainmasterContext = new TrainmasterContext();


        //////////add train////////////
        public void AddTrain(Traindetail Traindetails)
        {
            trainmasterContext.Traindetails.Add(Traindetails);
            trainmasterContext.SaveChanges();
        }

        public void UpdateTrain(int TrainNo, Traindetail modifiedTraindetail)
        {
            var Traindetail = trainmasterContext.Traindetails.Where(x => x.TrainNo == TrainNo).FirstOrDefault();
            if (Traindetail == null)
            {
                Console.WriteLine($"Train with No:{TrainNo} Not Found"); ;
            }

            ;
            Traindetail.FromStation = modifiedTraindetail.FromStation;
            Traindetail.ToStation = modifiedTraindetail.ToStation;
            Traindetail.JourneyStartTime = modifiedTraindetail.JourneyStartTime;
            Traindetail.JourneyEndTime = modifiedTraindetail.JourneyEndTime;



            // Entity state : Modified
            trainmasterContext.Traindetails.Update(Traindetail);

            // This issues insert statement
            trainmasterContext.SaveChanges();
        }
        public void DeleteTrain(int TrainNo)
        {
            var Traindetail = trainmasterContext.Traindetails.Where(x => x.TrainNo == TrainNo).FirstOrDefault();
            if (Traindetail == null)
            {
                throw new Exception($"Train Number:{TrainNo} Not Found");
            }

            // Entity state : Deleted
            trainmasterContext.Traindetails.Remove(Traindetail);

            // This issues insert statement
            trainmasterContext.SaveChanges();

            Console.WriteLine("delete done");
        }



        public Traindetail SearchtrainByNo(int TrainNo)
        {
            // Tracking not required
            var Traindetail = trainmasterContext.Traindetails.Where(x => x.TrainNo == TrainNo)
                            .AsNoTracking()
            .FirstOrDefaultAsync().Result;
            if (Traindetail == null)
            {
                throw new Exception($"train no=:{TrainNo} Not Found");
            }
            return Traindetail;


        }

        public Traindetail Searchingbystation(String FromStation,string ToStation)
        {
            var Traindetail = trainmasterContext.Traindetails.Where(x => x.FromStation == FromStation)
                .AsNoTracking().FirstOrDefaultAsync().Result;
            
            if (Traindetail == null)
            {
                throw new Exception($"train from =:{FromStation} Not Found");
            }
            return Traindetail;




        }
    }

}
