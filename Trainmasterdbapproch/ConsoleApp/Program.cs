using trainmaster.Models;


namespace trainmaster.Models
{

    public class Program

    {
        public static void Main()
        {

            Crudoperation obj = new Crudoperation();
            Console.WriteLine("Calling the methods !!!");

            ///-----------adding train details-//////////

            // Console.WriteLine("Adding a new Train details");
            // obj.AddTrain(new Traindetail { TrainNo = 1, TrainName = "rajdhani", FromStation = "lucknow", ToStation = "delhi", JourneyStartTime = new TimeSpan(2, 15, 00), JourneyEndTime = new TimeSpan(5, 15, 00) });
            //obj.AddTrain(new Traindetail { TrainNo = 2, TrainName = "intercity", FromStation = "lucknow", ToStation = "gorakhpur", JourneyStartTime = new TimeSpan(3, 20, 00), JourneyEndTime = new TimeSpan(9, 45, 00) });
            //obj.AddTrain(new Traindetail { TrainNo = 3, TrainName = "gorakhdham", FromStation = "delhi ", ToStation = "lucknow", JourneyStartTime = new TimeSpan(4, 25, 00), JourneyEndTime = new TimeSpan(12, 45, 00) });
            // obj.AddTrain(new Traindetail { TrainNo = 4, TrainName = "mumbai local", FromStation = "mumbai", ToStation = "banaras", JourneyStartTime = new TimeSpan(4, 25, 00), JourneyEndTime = new TimeSpan(12, 45, 00) });

            //////////////// update train details///////////////
            //Console.WriteLine("Updating traindetails  trainNO- 3");
            //obj.UpdateTrain(3,new Traindetail { TrainName = "LTTsuperfast", FromStation = "bihar ", ToStation = "mumbai",JourneyStartTime = new TimeSpan(1, 25, 00),JourneyEndTime = new TimeSpan(3, 05, 00) });



            //////////// delete train details //////////////

            // Console.WriteLine("Deleting train details train no 3");
            //obj.DeleteTrain(2);

            /////////////////// search train by train no//////////

            //Console.WriteLine("seraching train by train no");

            // var Traindetail = obj.SearchtrainByNo(2);
            //Console.WriteLine($" details of train No 2 = {Traindetail.TrainName}, from= {Traindetail.FromStation},to={Traindetail.ToStation},start time ={Traindetail.JourneyStartTime},End time ={Traindetail.JourneyEndTime}");

            ////////////----search train from station---////////////

            // Console.WriteLine("Search train from Station ");


            var Traindetail = obj.Searchingbystation("bihar", "mumbai");
            Console.WriteLine($" All train between bihar and mumbai Train NO={Traindetail.TrainNo},Train Name={Traindetail.TrainName}, from= {Traindetail.FromStation},to={Traindetail.ToStation},start time ={Traindetail.JourneyStartTime},End time ={Traindetail.JourneyEndTime}");


        }
    }
}