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
            int select;
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
                    case 1: // If the user select (1) a new menu will desplay for the patient 
                        
                        bool patientExit = false;
                        while (patientExit == false)
                        {  // Sub menu for patient 
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
                                    if (patientCount == MAX_PATIENTS) //Check if the number of patient = the maximum
                                        Console.WriteLine("Clinic is full. Cannot add more patients." );
                                    else
                                    {
                                        Console.Write("Enter patient name: ");
                                        string name = Console.ReadLine();
                                        if (name == "")
                                            Console.WriteLine("Error, the name can't be empty");
                                        else
                                        {
                                            Console.WriteLine("Enter patient age: ");
                                           int age = Convert.ToInt32(Console.ReadLine());
                                            if (age < 1 || age > 120)
                                            {
                                                Console.WriteLine("Error: Age must be between 1 and 120.");
                                            }
                                            else
                                            {
                                                Console.Write("Enter patient phone: ");
                                                string phone = Console.ReadLine();

                                                if (!p1Active)
                                                {
                                                    p1Name = name; p1Age = age; p1Phone = phone; p1Active = true;
                                                }
                                                else if (!p2Active)
                                                {
                                                    p2Name = name; p2Age = age; p2Phone = phone; p2Active = true;
                                                }
                                                else if (!p3Active)
                                                {
                                                    p3Name = name; p3Age = age; p3Phone = phone; p3Active = true;
                                                }

                                                patientCount++;
                                                Console.WriteLine("Patient added successfully.");
                                            }
                                        }
                                    }
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
                                    patientExit = true;
                                    break;
                            }
                        }
                        break;

                    case 2:  // If the user select (2) a new menu will desplay for the doctor 

                        bool doctorExit = false;
                        while (doctorExit == false)
                        {  // Sub menu for doctor
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
                                    doctorExit = true;
                                    break;
                            }
                        }
                        break;

                    case 3:  // If the user select (2) a new menu will desplay for the appointment 
                        bool appointmentExit = false;
                        while (appointmentExit == false)
                        {  // Sub menu for appointment
                            Console.WriteLine("");
                            Console.WriteLine("APPOINTMENT MANAGEMENT");
                            Console.WriteLine("");
                            Console.WriteLine("1. Book New Appointment ");
                            Console.WriteLine("");
                            Console.WriteLine("2. Display All Appointments");
                            Console.WriteLine("");
                            Console.WriteLine("3. Update Appointment Status ");
                            Console.WriteLine("");
                            Console.WriteLine("4. Cancel Appointment");
                            Console.WriteLine("");
                            Console.WriteLine("0. Back to Main Menu ");
                            Console.WriteLine("");

                            Console.Write("Select: ");
                            

                            select = Convert.ToInt32(Console.ReadLine());

                            switch(select)
                            {
                                case 1:
                                    Console.WriteLine("");
                                    Console.WriteLine("Book New Appointment");
                                    break;
                                case 2:
                                    Console.WriteLine("Display All Appointments");
                                    break;
                                case 3:
                                    Console.WriteLine("Update Appointment Status");
                                    break;
                                case 4:
                                    Console.WriteLine("Cancel Appointment");
                                    break;
                                case 0:
                                    Console.WriteLine("Exiting...");
                                    appointmentExit = true;
                                    break;
                            }
                        }     
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
