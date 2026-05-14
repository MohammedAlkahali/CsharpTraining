namespace CMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── REGION 1: System Storage ───
            // Capacity constants

            const int MAX_PATIENTS = 3;

            const int MAX_DOCTORS = 2;

            const int MAX_APPOINTMENTS = 3;


            // Patient slots

            string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;

            string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;

            string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;

            int patientCount = 0;


            // Doctor slots

            string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;

            string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;

            int doctorCount = 0;


            // Appointment slots

            string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status =
            ""; bool a1Active = false;

            string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status =
            ""; bool a2Active = false;

            string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status =
            ""; bool a3Active = false;

            int appointmentCount = 0;


            // Start Region 2 - Wrap the entire program in a while (true) loop.
            int choice;

            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("CLINIC MANAGEMENT SYSTEM ");  //|
                Console.WriteLine("1. Patient Management    ");  //|
                Console.WriteLine("2. Doctor Management     ");  //| ---> This is the main menu to choose from
                Console.WriteLine("3. Appointment Management");  //|
                Console.WriteLine("0. Exit                  ");  //|

                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" PATIENT MANAGEMENT");
                        break;
                    case 2:
                        Console.WriteLine("DOCTOR MANAGEMENT");
                        break;
                    case 3:
                        Console.WriteLine("APPOINTMENT MANAGEMENT");
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Error, Choose 1-3 or 0 to exit");
                        break;
                }
            }
        }
    }
}
