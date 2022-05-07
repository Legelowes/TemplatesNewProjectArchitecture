//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Framework - Static and Dynamic : Script File.cs
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
namespace FLORENCE_DevelopersTemplete
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
        public Framework(int num_implemented_cores)
        {
            this.framework_Dynamic_XxxxxxXxxxxx = new Dynamic_XxxxxxXxxxxx(num_implemented_cores);
            while(this.framework_Dynamic_XxxxxxXxxxxx == null) { }
        }


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        public void stop_DynamicFramework_Server_Backend()
        {
// Framework
            this.framework_Dynamic_XxxxxxXxxxxx = null;

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
        private Dynamic_XxxxxxXxxxxx framework_Dynamic_XxxxxxXxxxxx;

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------Framework
        public Dynamic_XxxxxxXxxxxx getDynamicFramework()
        {
            return this.framework_Dynamic_XxxxxxXxxxxx;
        }
    }
    public class Dynamic_XxxxxxXxxxxx
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
        public Dynamic_XxxxxxXxxxxx(int num_implemented_cores)
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Dynamic_XxxxxxXxxxxx
             //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Algorithms	
            this.algorithms = new FLORENCE_DevelopersTemplete.Algorithms(num_implemented_cores);
            while(this.algorithms == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Dynamic_XxxxxxXxxxxx/algorithms");//SIMULATION
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Control
    		this.control = new FLORENCE_DevelopersTemplete.Control();
            while(this.control == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Dynamic_XxxxxxXxxxxx/control");//SIMULATION
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Data
            this.data = new FLORENCE_DevelopersTemplete.Data(num_implemented_cores);
            while(this.data == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Dynamic_XxxxxxXxxxxx/data");//SIMULATION
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Control/Data
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/Concurrent_InputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/PraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/PreMadeEmptyInputPraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/Stack_InputPraise
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Data/Output
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Data/Output
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/Concurrent_OutputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/PraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/PreMadeEmptyOutputPraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/Stack_OutputPraise
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Execute
            this.execute = new FLORENCE_DevelopersTemplete.Execute(num_implemented_cores);
            while(this.execute == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Dynamic_XxxxxxXxxxxx/execute");//SIMULATION
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Control/Execute

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Wrapper
            this.wrapper = new FLORENCE_DevelopersTemplete.TerminalWrapper();
            while(this.wrapper == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Dynamic_XxxxxxXxxxxx/wrapper");//SIMULATION

// THREADED CORES
            this.thread_WithCoreId = new System.Threading.Thread[num_implemented_cores];
            while(this.thread_WithCoreId == null) {/* wait untill field created */}

            for(int coreId = 1; coreId < this.thread_WithCoreId.Length; coreId++) 
            {
                this.thread_WithCoreId[coreId] = new System.Threading.Thread(()=>this.getInstance_Execute().thread_Concurrency(this, coreId));
                while(this.thread_WithCoreId[coreId] == null) {/* wait untill field created */}
                this.thread_WithCoreId[coreId].Start();
                while(this.getInstance_Control_Execute().getFlag_ThreadInitialised(coreId) != false) {/* wait untill thread initialised */}   
            }
        
            this.thread_WithCoreId[0] = CurrentThread;
            this.getInstance_Execute().thread_IO_ListenDistribute(this, 0);
        }

        ~Dynamic_XxxxxxXxxxxx()
        {
// THREADED CORES
            for(int index = 0; index < this.thread_WithCoreId.Length; index++) 
            {
                this.thread_WithCoreId[index] = null;
            }
        }

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
// THREADED CORES
        public static System.Threading.Thread CurrentThread { get; }

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------
// INSTANCE(S)
// TIER ALPHA (Top) :: Dynamic_XxxxxxXxxxxx
        //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Algorithms	
        public Algorithms getInstance_Algorithms()
		{
			return this.algorithms;
		}            
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Control/Algorithms
        public Control_Algorithms getInstance_Control_Algorithms()
        {
            return this.getInstance_Algorithms().getInstance_Control_Algorithms();
        }
    // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Algorithms//Concurrent
        public Algorithms_Concurrent getInstance_Algorithms_Concurrent(int index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index);
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Algorithms/Concurrent
        public Control_Algorithms_Concurrent getInstance_Control_Algorithms_Concurrent(int index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index).getInstance_Control_Algorithms_Concurrent();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Algorithms/ListenRespond
        public Algorithms_ListenRespond getInstance_Algorithms_ListenRespond()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Algorithms/ListenRespond
        public Control_Algorithms_ListenRespond getInstance_Control_Algorithms_ListenRespond()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond().getInstance_Control_Algorithms_ListenRespond();
        }

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Control
    	public Control getInstance_Control()
		{
			return this.control;
		}	
       
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Data
        public Data getInstance_Data()
		{
			return this.data;
		}
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Control/Data
        public Control_Data getInstance_Control_Data()
        {
            return this.getInstance_Data().getInstance_Control_Data();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Data/Input
        public Data_Input getInstance_Data_Input()
        {
            return this.getInstance_Data().getInstance_Data_Input();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Data/Input
        public Control_Data_Input getInstance_Control_Data_Input()
        {
            return this.getInstance_Data().getInstance_Control_Data_Input();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/Concurrent_InputRefferenceOfCore
        public Data_Input getInstance_Data_Input_Concurrent_InputRefferenceOfCore(int coreId)
        {
            return this.getInstance_Data().getInstance_Data_Input_Concurrent_InputRefferenceOfCore(coreId);
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/PraiseBuffer
        public Data_Input getInstance_Data_Input_PraiseBuffer()
        {
            return this.getInstance_Data().getInstance_Data_Input_PraiseBuffer();
        }

            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/PreMadeEmptyInputPraiseBuffer
        public Data_Input getInstance_Data_Input_PreMadeEmptyInputPraiseBuffer()
        {
            return this.getInstance_Data().getInstance_Data_Input_PreMadeEmptyInputPraiseBuffer();
        }

            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/Stack_InputPraise
        public Data_Input[] getInstance_Data_Input_Stack_InputPraise()
        {
            return this.getInstance_Data().getInstance_Data_Input_Stack_InputPraise();
        }

        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Data/Output
        public Data_Output getInstance_Data_Output()
        {
            return this.getInstance_Data().getInstance_Data_Output();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Data/Output
        public Control_Data_Output getInstance_Control_Data_Output()
        {
            return this.getInstance_Data().getInstance_Control_Data_Output();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/Concurrent_OutputRefferenceOfCore
        public Data_Output getInstance_Data_Output_Concurrent_OutputRefferenceOfCore(int coreId)
        {
            return this.getInstance_Data().getInstance_Data_Output_Concurrent_OutputRefferenceOfCore(coreId);
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/DistributeBuffer
        public Data_Output getInstance_Data_Output_DistributeBuffer()
        {
            return this.getInstance_Data().getInstance_Data_Output_PraiseBuffer();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/PreMadeEmptyOutputPraiseBuffer
        public Data_Output getInstance_Data_Output_PreMadeEmptyOutputPraiseBuffer()
        {
            return this.getInstance_Data().getInstance_Data_Output_PreMadeEmptyOutputPraiseBuffer();
        } 
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/Stack_OutputPraise
        public Data_Output[] getInstance_Data_Output_Stack_OutputPraise()
        {
            return this.getInstance_Data().getInstance_Data_Output_Stack_OutputPraise();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Data/Reconnaissance
        public Data_Reconnaissance getInstance_Data_Reconnaissance()
        {
            return this.getInstance_Data().getInstance_Data_Reconnaissace();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Data/Reconniassance
        public Control_Data_Reconnaissance getInstance_Control_Data_Reconnaissance()
        {
            return this.getInstance_Data().getInstance_Control_Data_Reconnaissace();
        }

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Execute
        public Execute getInstance_Execute()
		{
			return this.execute;
		}
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Control/Execute
        public Control_Execute getInstance_Control_Execute()
        {
            return this.getInstance_Execute().getInstance_Control_Execute();
        }

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Wrapper
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
// TIER ALPHA (Top) :: Dynamic_XxxxxxXxxxxx
             //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Algorithms	
        private Algorithms algorithms;    
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Control
    	private Control control;	
       
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Data
        private Data data;    
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Control/Data
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/Concurrent_InputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/PraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/PreMadeEmptyInputPraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Input/Stack_InputPraise
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Data/Output
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Data/Output
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/Concurrent_OutputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/PraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/PreMadeEmptyOutputPraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Data/Output/Stack_OutputPraise
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxx/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Execute
        private Execute execute;
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxx/Control/Execute

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxx/Wrapper
        private TerminalWrapper wrapper;

// THREADED CORES
	    private System.Threading.Thread[] thread_WithCoreId;

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------

    }
}
//End <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<