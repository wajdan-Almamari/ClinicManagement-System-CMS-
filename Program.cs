namespace ClinicManagement_System_CMS_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ── REGION 1: System Storage ───────────────────────────────────── 
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
            string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; 
            string a1Status = ""; bool a1Active = false;
            string a2Patient = ""; string a2Doctor = ""; string a2Date = "";
            string a2Status = ""; bool a2Active = false;
            string a3Patient = ""; string a3Doctor = ""; string a3Date = "";
            string a3Status = ""; bool a3Active = false; int appointmentCount = 0;

            // ── REGION 2: Main Menu   ───────────────────────────────────── 

            Console.WriteLine(" ╔══════════════════════════════════════╗");
            Console.WriteLine(" ║     CLINIC MANAGEMENT SYSTEM         ║");
            Console.WriteLine(" ║══════════════════════════════════════╣");
            Console.WriteLine(" ║  1. Patient Management               ║");              
            Console.WriteLine(" ║  2. Doctor Management                ║");
            Console.WriteLine(" ║  3. Appointment Management           ║");
            Console.WriteLine(" ║  0. Exit                             ║");
            Console.WriteLine(" ╚══════════════════════════════════════╝");
            Console.Write(" Enter your choice: ");

            int EnterChoise = int.Parse(Console.ReadLine());
            
            switch (EnterChoise)
            {
                 //1. Patient Management
                case 1:
                    Console.WriteLine(" ╔══════════════════════════════════════╗");
                    Console.WriteLine(" ║       PATIENT MANAGEMENT             ║");
                    Console.WriteLine(" ║══════════════════════════════════════╣");
                    Console.WriteLine(" ║ 1. Add New Patient                   ║");
                    Console.WriteLine(" ║ 2. Display All Patients              ║");
                    Console.WriteLine(" ║ 3. Update Patient Phone              ║");
                    Console.WriteLine(" ║ 4. Delete Patient                    ║");
                    Console.WriteLine(" ║ 0. Back to Main Men                  ║");
                    Console.WriteLine(" ╚══════════════════════════════════════╝");
                    Console.Write(" Enter your choice: ");

                    int EnterChoiseP = int.Parse(Console.ReadLine());
                    switch (EnterChoiseP)
                    {
                        //1. Add New Patient 
                        case 1:
                            
                            Console.WriteLine("1.Add New Patient");
                            if (patientCount == MAX_PATIENTS)
                            {
                                Console.WriteLine("Clinic is full. Cannot add more patients.");
                            }
                            else
                            {

                            }
                                break;
                        //2. Display All Patients  
                        case 2:
                            Console.WriteLine();
                            break;
                        //3. Update Patient Phone
                        case 3:
                            Console.WriteLine();
                            break;
                        //4. Delete Patient
                        case 4:
                            Console.WriteLine();
                            break;
                        //0. Back to Main Menu 
                        case 0:
                            Console.WriteLine();
                            break;

                    }//End switch 

                    break;
                 // 2.Doctor Management
                case 2:
             
                    Console.WriteLine(" ╔══════════════════════════════════════╗");
                    Console.WriteLine(" ║       DOCTOR MANAGEMENT              ║");
                    Console.WriteLine(" ║══════════════════════════════════════╣");
                    Console.WriteLine(" ║ 1. Add New Doctor                    ║");
                    Console.WriteLine(" ║ 2. Display All Doctors               ║");
                    Console.WriteLine(" ║ 3. Update Consultation Fee           ║");
                    Console.WriteLine(" ║ 4. Delete Doctor                     ║");
                    Console.WriteLine(" ║ 0. Back to Main Men                  ║");
                    Console.WriteLine(" ╚══════════════════════════════════════╝");
                    Console.Write(" Enter your choice: ");
                    int EnterChoiseD = int.Parse(Console.ReadLine());

                    break;
                 //3.Appointment Management
                case 3:
                    Console.WriteLine(" ╔══════════════════════════════════════╗");
                    Console.WriteLine(" ║       APPOINTMENT MANAGEMENT         ║");
                    Console.WriteLine(" ║══════════════════════════════════════╣");
                    Console.WriteLine(" ║ 1. Book New Appointment              ║");
                    Console.WriteLine(" ║ 2. Display All Appointments          ║");
                    Console.WriteLine(" ║ 3. Update Appointment Status         ║");
                    Console.WriteLine(" ║ 4. Cancel Appointment                ║");
                    Console.WriteLine(" ║ 0. Back to Main Men                  ║");
                    Console.WriteLine(" ╚══════════════════════════════════════╝");
                    Console.Write(" Enter your choice: ");
                    int EnterChoiseA = int.Parse(Console.ReadLine());

                    break;
                 //0.Exit
                case 0:
                    Console.WriteLine();
                    break;

            }//EndSwitch



        }
    }
}
