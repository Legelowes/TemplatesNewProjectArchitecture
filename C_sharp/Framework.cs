//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Terminal Wrapper : Script File.cs
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
namespace FLORENCE_Server_ClientServerAssembly
{
    public class Framework
    {
//	PUBLIC -==============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	CONSTRUCTOR ******************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        public Framework(sbyte num_Comcurrent_Cores)
        {
            this.framework_Static_Server_Backend = new Static_Server_Backend(num_Comcurrent_Cores);
            while(this.framework_Static_Server_Backend == null) { }
            this.framework_Dynamic_Server_Backend = new Dynamic_Server_Backend(this.framework_Static_Server_Backend, num_Comcurrent_Cores);
            while(this.framework_Dynamic_Server_Backend == null) { }
        }


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        public void stop_DynamicFramework_Server_Backend()
        {
            this.framework_Dynamic_Server_Backend = null;

            System.Console.WriteLine("        ,     \\      /      ,");//SIMULATION
			System.Console.WriteLine("       / \\    )\\ __ /(     / \\ ");//SIMULATION
			System.Console.WriteLine("      /   \\   (_\\  /_)    /   \\ ");//SIMULATION
			System.Console.WriteLine("____ / ____\\__ \\@  @/ ___/_____\\_____");//SIMULATION
			System.Console.WriteLine("|              |\\../|               |");//SIMULATION
			System.Console.WriteLine("|               \\VV/                |");//SIMULATION
			System.Console.WriteLine("|      SHUTDOWN INSTANCIATION       |");//SIMULATION
			System.Console.WriteLine("|___________________________________|");//SIMULATION
			System.Console.WriteLine("|    / \\ /        \\\\        \\ /\\    |");//SIMULATION
			System.Console.WriteLine("|  /    V          ))        V   \\  |");//SIMULATION
			System.Console.WriteLine("|/                //               \\| ");//SIMULATION
			System.Console.WriteLine("`                 V                 '");//SIMULATION
        }
//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------



//	PROTECTED ============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------



//	PRIVATE ==============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        private Static_Server_Backend framework_Static_Server_Backend;
        private Dynamic_Server_Backend framework_Dynamic_Server_Backend;

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------Framework
        public Dynamic_Server_Backend getDynamicFramework()
        {
            return this.framework_Dynamic_Server_Backend;
        }
        public Static_Server_Backend getStaticFramework()
        {
            return this.framework_Static_Server_Backend;
        }
          
    }
    public class Static_Server_Backend
    {
//	PUBLIC -==============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	CONSTRUCTOR ******************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        public Static_Server_Backend(sbyte num_Comcurrent_Cores)
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Static_Server_Backend
             //this;
	
    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Algorithms	
            this.algorithms = new FLORENCE_Server_ClientServerAssembly.Algorithms(num_Comcurrent_Cores);
            while(this.algorithms == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_Server_Backend/algorithms");//SIMULATION
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Control
    		this.control = new FLORENCE_Server_ClientServerAssembly.Control();
            while(this.control == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_Server_Backend/control");//SIMULATION
    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Data
            this.data = new FLORENCE_Server_ClientServerAssembly.Data(num_Comcurrent_Cores);
            while(this.data == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_Server_Backend/data");//SIMULATION
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Control/Data
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Data/Input
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Data/Input
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Data/Ouput
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Data/Output
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Data/Reconnasissance

    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Execute
            this.execute = new FLORENCE_Server_ClientServerAssembly.Execute();
            while(this.execute == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_Server_Backend/execute");//SIMULATION
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Control/Execute

    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Wrapper
            this.wrapper = new FLORENCE_Server_ClientServerAssembly.TerminalWrapper();
            while(this.wrapper == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_Server_Backend/wrapper");//SIMULATION
    
        }
        ~Static_Server_Backend()
        {

        }

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        public void addThisInstanceToArray(Object value)
        {
            Object[] temp_Array = new Object[instanceArray.Length+1];
            for(sbyte index = 0; index < instanceArray.Length; index++)
            {
                temp_Array[index] = instanceArray[index];
            }
            temp_Array[instanceArray.Length+1] = value;
            instanceArray = temp_Array;
        }
//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------
// INSTANCE(S)
// TIER ALPHA (Top) :: Static_Server_Backend
             //this;
	
    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Algorithms	
        public Algorithms getInstance_Algorithms()
		{
			return this.algorithms;
		}            
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Control/Algorithms
        public Control_Algorithms getInstance_Control_Algorithms()
        {
            return this.getInstance_Algorithms().getInstance_Control_Algorithms();
        }
    // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Algorithms//Concurrent
        public Algorithms_Concurrent getInstance_Algorithms_Concurrent(sbyte index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index);
        }
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Algorithms/Concurrent
        public Control_Algorithms_Concurrent getInstance_Control_Algorithms_Concurrent(sbyte index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index).getInstance_Control_Algorithms_Concurrent(index);
        }
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Algorithms/ListenRespond
        public Algorithms_ListenRespond getInstance_Algorithms_ListenRespond()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond();
        }
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Algorithms/ListenRespond
        public Control_Algorithms_ListenRespond getInstance_Control_Algorithms_ListenRespond()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond().getInstance_Control_Algorithms_ListenRespond();
        }

    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Control
    	public Control getInstance_Control()
		{
			return this.control;
		}	
       
    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Data
        public Data getInstance_Data()
		{
			return this.data;
		}            
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Control/Data
        public Control_Data getInstance_Control_Data()
        {
            return this.getInstance_Data().getInstance_Control_Data();
        }
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Data/Input
        public Data_Input getInstance_Data_Input()
        {
            return this.getInstance_Data().getInstance_Data_Input();
        }
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Data/Input
        public Control_Data_Input getInstance_Control_Data_Input()
        {
            return this.getInstance_Data().getInstance_Data_Input().getInstance_Control_Data_Input();
        }
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Data/Ouput
        public Data_Output getInstance_Data_Output()
        {
            return this.getInstance_Data().getInstance_Data_Output();
        }
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Data/Output
        public Control_Data_Output getInstance_Control_Data_Output()
        {
            return this.getInstance_Data().getInstance_Data_Output().getInstance_Control_Data_Output();
        }
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Data/Reconnaissance
        public Data_Reconnaissance getInstance_Data_Reconnaissance()
        {
            return this.getInstance_Data().getInstance_Data_Reconnaissance();
        }
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Data/Reconnaissance
        public Control_Data_Reconnaissance getInstance_Control_Data_Reconnaissance()
        {
            return this.getInstance_Data().getInstance_Data_Reconnaissance().getInstance_Control_Data_Reconnaissance();
        }
    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Execute
        public Execute getInstance_Execute()
		{
			return this.execute;
		}
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Control/Execute
        public Control_Execute getInstance_Control_Execute()
        {
            return this.getInstance_Execute().getInstance_Control_Execute();
        }

    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Wrapper
        public TerminalWrapper getInstance_TerminalWrapper()
		{
			return this.wrapper;
		}



//	PROTECTED ============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------



//	PRIVATE ==============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
// INSTANCE(S)
        private Object[] instanceArray = new Object[18];

// TIER ALPHA (Top) :: Static_Server_Backend
             //this;
	
    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Algorithms	
        private Algorithms algorithms;    
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Control
    	private Control control;	
       
    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Data
        private Data data;    
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Control/Data
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Data/Input
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Data/Input
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Data/Ouput
            // TIER DELTA (Top - 3) :: Static_Server_Backend/Control/Data/Output
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Execute
        private Execute execute;
        // TIER CHARLIE (Top - 2) :: Static_Server_Backend/Control/Execute

    // TIER BRAVO (Top - 1) :: Static_Server_Backend/Wrapper
        private TerminalWrapper wrapper;

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------

    }
    public class Dynamic_Server_Backend 
    {
//	PUBLIC -==============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	CONSTRUCTOR ******************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        public Dynamic_Server_Backend(Static_Server_Backend static_obj, sbyte num_Comcurrent_Cores)
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Dynamic_Server_Backend
             //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Algorithms	
            this.algorithms = static_obj.getInstance_Algorithms();
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Control
        	this.control = static_obj.getInstance_Control();
       
    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Data
            this.data = static_obj.getInstance_Data();
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Data
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Input
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Ouput
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Output
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Execute
            this.execute = static_obj.getInstance_Execute();
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Execute

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Wrapper
            this.wrapper = static_obj.getInstance_TerminalWrapper();
		
// HREADED CORES
			this.td_IO_Loader_Simulation = new Thread(()=>static_obj.getInstance_Execute().td_IO_Loader_Simulation(this));
			this.td_Concurreny_0 = new Thread(()=>static_obj.getInstance_Execute().td_Concurreny(this));
			this.td_Concurreny_1 = new Thread(()=>static_obj.getInstance_Execute().td_Concurreny(this));

            //while (checkList_PriorToConcurrentLaunch(static_obj, this, num_Comcurrent_Cores) == false) {}

			System.Console.WriteLine("        ,     \\      /      ,");//SIMULATION
			System.Console.WriteLine("       / \\    )\\ __ /(     / \\ ");//SIMULATION
			System.Console.WriteLine("      /   \\   (_\\  /_)    /   \\ ");//SIMULATION
			System.Console.WriteLine("____ / ____\\__ \\@  @/ ___/_____\\_____");//SIMULATION
			System.Console.WriteLine("|              |\\../|               |");//SIMULATION
			System.Console.WriteLine("|               \\VV/                |");//SIMULATION
			System.Console.WriteLine("|             FLORANCE              |");//SIMULATION
			System.Console.WriteLine("|        DEVELOPERS TEMPLATE        |");//SIMULATION
			System.Console.WriteLine("|___________________________________|");//SIMULATION
			System.Console.WriteLine("|    / \\ /        \\\\        \\ /\\    |");//SIMULATION
			System.Console.WriteLine("|  /    V          ))        V   \\  |");//SIMULATION
			System.Console.WriteLine("|/                //               \\| ");//SIMULATION
			System.Console.WriteLine("`                 V                 '");//SIMULATION

            this.td_IO_Loader_Simulation.Start();
            this.td_Concurreny_0.Start();
            this.td_Concurreny_1.Start();

		}
        ~Dynamic_Server_Backend()
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Dynamic_Server_Backend
             //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Algorithms	
            this.algorithms = null;
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Control
        	this.control = null;
       
    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Data
            this.data = null;
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Data
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Input
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Ouput
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Output
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Execute
            this.execute = null;
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Execute

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Wrapper
            this.wrapper = null;
		
// HREADED CORES
			this.td_IO_Loader_Simulation = null;
			this.td_Concurreny_0 = null;
			this.td_Concurreny_1 = null;

            System.Console.WriteLine("        ,     \\      /      ,");//SIMULATION
			System.Console.WriteLine("       / \\    )\\ __ /(     / \\ ");//SIMULATION
			System.Console.WriteLine("      /   \\   (_\\  /_)    /   \\ ");//SIMULATION
			System.Console.WriteLine("____ / ____\\__ \\@  @/ ___/_____\\_____");//SIMULATION
			System.Console.WriteLine("|              |\\../|               |");//SIMULATION
			System.Console.WriteLine("|               \\VV/                |");//SIMULATION
			System.Console.WriteLine("|        SHUTDOWN CONCURRENCY       |");//SIMULATION
			System.Console.WriteLine("|___________________________________|");//SIMULATION
			System.Console.WriteLine("|    / \\ /        \\\\        \\ /\\    |");//SIMULATION
			System.Console.WriteLine("|  /    V          ))        V   \\  |");//SIMULATION
			System.Console.WriteLine("|/                //               \\| ");//SIMULATION
			System.Console.WriteLine("`                 V                 '");//SIMULATION
        }

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------
// INSTANCE(S)
// TIER ALPHA (Top) :: Dynamic_Server_Backend
             //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Algorithms	
        public Algorithms getInstance_Algorithms()
        {
            return this.algorithms;
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Algorithms
        public Control_Algorithms getInstance_Control_Algorithms()
        {
            return this.getInstance_Algorithms().getInstance_Control_Algorithms();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Algorithms/Concurrent
        public Algorithms_Concurrent getInstance_Algorithms_Concurrent(sbyte index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index);
        }
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Algorithms/Concurrent
        public Control_Algorithms_Concurrent getInstance_Control_Algorithms_Concurrent(sbyte index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index).getInstance_Control_Algorithms_Concurrent(index);
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Algorithms/ListenRespond
        public Algorithms_ListenRespond getInstance_Algorithms_ListenRespnd()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond();
        }
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Algorithms/ListenRespond
        public Control_Algorithms_ListenRespond getInstance_Control_Algorithms_ListenRespond()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond().getInstance_Control_Algorithms_ListenRespond();
        }

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Control
        public Control getInstance_Control()
        {
            return this.control;
        }
       
    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Data
        public Data getInstance_Data()
        {
            return this.data;
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Data
        public Control_Data getInstance_Control_Data()
        {
            return this.getInstance_Data().getInstance_Control_Data();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Input
        public Data_Input getInstance_Data_Input()
        {
            return this.getInstance_Data().getInstance_Data_Input();
        }
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Input
        public Control_Data_Input getInstance_Control_Data_Input()
        {
            return this.getInstance_Data().getInstance_Data_Input().getInstance_Control_Data_Input();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Ouput
        public Data_Output getInstance_Data_Output()
        {
            return this.getInstance_Data().getInstance_Data_Output();
        }
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Output
        public Control_Data_Output getInstance_Control_Data_Output()
        {
            return this.getInstance_Data().getInstance_Data_Output().getInstance_Control_Data_Output();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Reconnaissance
        public Data_Reconnaissance getInstance_Data_Reconnaissance()
        {
            return this.getInstance_Data().getInstance_Data_Reconnaissance();
        }
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Reconnaissance
        public Control_Data_Reconnaissance getInstance_Control_Data_Reconniassance()
        {
            return this.getInstance_Data().getInstance_Data_Reconnaissance().getInstance_Control_Data_Reconnaissance();
        }

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Execute
        public Execute getInstance_Execute()
        {
            return this.execute;
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Execute
        public Control_Execute getInstance_Control_Execute()
        {
            return this.getInstance_Execute().getInstance_Control_Execute();
        } 

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Wrapper
        public TerminalWrapper getInstance_TerminalWrapper()
        {
            return this.wrapper;
        }


//	PROTECTED ============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------



//	PRIVATE ==============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

        
//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
// INSTANCE(S)
// TIER ALPHA (Top) :: Dynamic_Server_Backend
             //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Algorithms	
            private Algorithms algorithms;
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Control
        	private Control control;
       
    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Data
            private Data data;
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Data
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Input
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Ouput
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Output
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Dynamic_Server_Backend/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Execute
            private Execute execute;
        // TIER CHARLIE (Top - 2) :: Dynamic_Server_Backend/Control/Execute

    // TIER BRAVO (Top - 1) :: Dynamic_Server_Backend/Wrapper
            private TerminalWrapper wrapper;

// THREADED CORES
	    private System.Threading.Thread td_IO_Loader_Simulation;
	    private System.Threading.Thread td_Concurreny_0;
	    private System.Threading.Thread td_Concurreny_1;


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------

    }
}
//End <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<