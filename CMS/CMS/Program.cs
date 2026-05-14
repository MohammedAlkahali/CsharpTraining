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
                Console.WriteLine("CLINIC MANAGEMENT SYSTEM" );  //|
                Console.WriteLine("");                           //|
                Console.WriteLine("1. Patient Management"    );  //|
                Console.WriteLine("");                           //|
                Console.WriteLine("2. Doctor Management"     );  //| ---> This is the main menu to choose from
                Console.WriteLine("");                           //|                                        
                Console.WriteLine("3. Appointment Management");  //|
                Console.WriteLine("");                           //|
                Console.WriteLine("0. Exit"                  );
                Console.WriteLine(""); 

                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: // If the user select (1) a new menu will desplay for the patient to choose
                        int select;
                        while (exit == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" PATIENT MANAGEMENT"     );
                            Console.WriteLine("");
                            Console.WriteLine(" 1. Add New Patient"     );
                            Console.WriteLine("");
                            Console.WriteLine(" 2. Display All Patients");
                            Console.WriteLine("");
                            Console.WriteLine(" 3. Update Patient Phone");
                            Console.WriteLine("");
                            Console.WriteLine(" 4. Delete Patient"      );
                            Console.WriteLine("");
                            Console.WriteLine(" 0. Back to Main Menu"   );
                            Console.WriteLine("");

                            Console.Write("Select: ");

                            select = Convert.ToInt32(Console.ReadLine());

                            switch(select)
                            {
                                case 1:
                                    Console.WriteLine(" ADD Patient ");
                                    break;
                                case 2: 
                                    Console.WriteLine("DISPLAY ALL Patients ");
                                    break;
                                case 3: 
                                    Console.WriteLine("UPDATE Patient Phone ");
                                    break;
                                case 4:
                                    Console.WriteLine("DELETE Patient ");
                                    break;
                                case 0:
                                    Console.WriteLine("Exiting...");
                                    exit = true;
                                    break;
                            }
                        }
                        break;

                    case 2:
                        while (exit == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("DOCTOR MANAGEMENT");
                            Console.WriteLine("");
                            Console.WriteLine(" 1. Add New Doctor ");
                            Console.WriteLine("");
                            Console.WriteLine(" 2. Display All Doctors");
                            Console.WriteLine("");
                            Console.WriteLine(" 3. Update Consultation Fee ");
                            Console.WriteLine("");
                            Console.WriteLine(" 4. Delete Doctor");
                            Console.WriteLine("");
                            Console.WriteLine(" 0. Back to Main Menu");
                            Console.WriteLine("");

                            Console.Write("Select: ");

                            select = Convert.ToInt32(Console.ReadLine());

                            switch (select)
                            {
                                case 1:
                                    Console.WriteLine(" ADD Doctor ");
                                    break;
                                case 2:
                                    Console.WriteLine("DISPLAY ALL Doctors ");
                                    break;
                                case 3:
                                    Console.WriteLine("Update Consultation Fee ");
                                    break;
                                case 4:
                                    Console.WriteLine("DELETE Doctor ");
                                    break;
                                case 0:
                                    Console.WriteLine("Exiting...");
                                    exit = true;
                                    break;
                            }
                        }
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
