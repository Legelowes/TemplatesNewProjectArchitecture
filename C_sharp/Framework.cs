//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Framework - Static and Dynamic : Script File.cs
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
namespace FLORANCE_DevelopersTemplete
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
            this.framework_Static_XxxxxxXxxxxx = new Static_XxxxxxXxxxxx(num_implemented_cores);
            while(this.framework_Static_XxxxxxXxxxxx == null) { }
            this.framework_Dynamic_XxxxxxXxxxxx = new Dynamic_XxxxxxXxxxxxx(this.framework_Static_XxxxxxXxxxxx, num_implemented_cores);
            while(this.framework_Dynamic_XxxxxxXxxxxx == null) { }
        }


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        public void stop_DynamicFramework_Server_Backend()
        {
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
        private Static_XxxxxxXxxxxx framework_Static_XxxxxxXxxxxx;
        private Dynamic_XxxxxxXxxxxxx framework_Dynamic_XxxxxxXxxxxx;

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------Framework
        public Dynamic_XxxxxxXxxxxxx getDynamicFramework()
        {
            return this.framework_Dynamic_XxxxxxXxxxxx;
        }
        public Static_XxxxxxXxxxxx getStaticFramework()
        {
            return this.framework_Static_XxxxxxXxxxxx;
        }
          
    }
    public class Static_XxxxxxXxxxxx
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
        public Static_XxxxxxXxxxxx(int num_implemented_cores)
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Static_XxxxxxXxxxxx
             //this;
	
    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Algorithms	
            this.algorithms = new FLORANCE_DevelopersTemplete.Algorithms(num_implemented_cores);
            while(this.algorithms == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_XxxxxxXxxxxx/algorithms");//SIMULATION
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Control
    		this.control = new FLORANCE_DevelopersTemplete.Control();
            while(this.control == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_XxxxxxXxxxxx/control");//SIMULATION
    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Data
            this.data = new FLORANCE_DevelopersTemplete.Data(num_implemented_cores);
            while(this.data == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_XxxxxxXxxxxx/data");//SIMULATION
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Control/Data
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Data/Input
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Data/Input
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/Concurrent_InputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/PraiseBuffer
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/PreMadeEmptyInputPraiseBuffer
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/Stack_InputPraise
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Data/Output
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Data/Output
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/Concurrent_OutputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/PraiseBuffer
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/PreMadeEmptyOutputPraiseBuffer
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/Stack_OutputPraise
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Execute
            this.execute = new FLORANCE_DevelopersTemplete.Execute();
            while(this.execute == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_XxxxxxXxxxxx/execute");//SIMULATION
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Control/Execute

    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Wrapper
            this.wrapper = new FLORANCE_DevelopersTemplete.TerminalWrapper();
            while(this.wrapper == null) { } //wait.
            System.Console.WriteLine(">> >> >> Object CREATED : Static_XxxxxxXxxxxx/wrapper");//SIMULATION
        }

        ~Static_XxxxxxXxxxxx()
        {

        }

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------
// INSTANCE(S)
// TIER ALPHA (Top) :: Static_XxxxxxXxxxxx
        //this;
	
    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Algorithms	
        public Algorithms getInstance_Algorithms()
		{
			return this.algorithms;
		}            
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Control/Algorithms
        public Control_Algorithms getInstance_Control_Algorithms()
        {
            return this.getInstance_Algorithms().getInstance_Control_Algorithms();
        }
    // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Algorithms//Concurrent
        public Algorithms_Concurrent getInstance_Algorithms_Concurrent(int index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index);
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Algorithms/Concurrent
        public Control_Algorithms_Concurrent getInstance_Control_Algorithms_Concurrent(int index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index).getInstance_Control_Algorithms_Concurrent();
        }
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Algorithms/ListenRespond
        public Algorithms_ListenRespond getInstance_Algorithms_ListenRespond()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond();
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Algorithms/ListenRespond
        public Control_Algorithms_ListenRespond getInstance_Control_Algorithms_ListenRespond()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond().getInstance_Control_Algorithms_ListenRespond();
        }

    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Control
    	public Control getInstance_Control()
		{
			return this.control;
		}	
       
    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Data
        public Data getInstance_Data()
		{
			return this.data;
		}
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Control/Data
        public Control_Data getInstance_Control_Data()
        {
            return this.getInstance_Data().getInstance_Control_Data();
        }
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Data/Input
        public Data_Input getInstance_Data_Input()
        {
            return this.getInstance_Data().getInstance_Data_Input();
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Data/Input
        public Control_Data_Input getInstance_Control_Data_Input()
        {
            return this.getInstance_Data().getInstance_Control_Data_Input();
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/Concurrent_InputRefferenceOfCore
        public Data_Input getInstance_Data_Input_Concurrent_InputRefferenceOfCore(int coreId)
        {
            return this.getInstance_Data().getInstance_Data_Input_Concurrent_InputRefferenceOfCore(coreId);
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/PraiseBuffer
        public Data_Input getInstance_Data_Input_PraiseBuffer()
        {
            return this.getInstance_Data().getInstance_Data_Input_PraiseBuffer();
        }

            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/PreMadeEmptyInputPraiseBuffer
        public Data_Input getInstance_Data_Input_PreMadeEmptyInputPraiseBuffer()
        {
            return this.getInstance_Data().getInstance_Data_Input_PreMadeEmptyInputPraiseBuffer();
        }

            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/Stack_InputPraise
        public Data_Input getInstance_Data_Input_Stack_InputPraise()
        {
            return this.getInstance_Data().getInstance_Data_Input_Stack_InputPraise();
        }

        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Data/Output
        public Data_Output getInstance_Data_Output()
        {
            return this.getInstance_Data().getInstance_Data_Output();
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Data/Output
        public Control_Data_Output getInstance_Control_Data_Output()
        {
            return this.getInstance_Data().getInstance_Control_Data_Output();
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/Concurrent_OutputRefferenceOfCore
        public Data_Output getInstance_Data_Output_Concurrent_OutputRefferenceOfCore(int coreId)
        {
            return this.getInstance_Data().getInstance_Data_Output_Concurrent_OutputRefferenceOfCore(coreId);
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/PraiseBuffer
        public Data_Output getInstance_Data_Output_PraiseBuffer()
        {
            return this.getInstance_Data().getInstance_Data_Output_PraiseBuffer();
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/PreMadeEmptyOutputPraiseBuffer
        public Data_Output getInstance_Data_Output_PreMadeEmptyOutputPraiseBuffer()
        {
            return this.getInstance_Data().getInstance_Data_Output_PreMadeEmptyOutputPraiseBuffer();
        } 
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/Stack_OutputPraise
        public Data_Output getInstance_Data_Output_Stack_OutputPraise()
        {
            return this.getInstance_Data().getInstance_Data_Output_Stack_OutputPraise();
        }
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Data/Reconnaissance
        public Data_Reconnaissance getInstance_Data_Reconnaissance()
        {
            return this.getInstance_Data().getInstance_Data_Reconnaissace();
        }
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Data/Reconniassance
        public Control_Data_Reconnaissance getInstance_Control_Data_Reconnaissance()
        {
            return this.getInstance_Data().getInstance_Control_Data_Reconnaissace();
        }

    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Execute
        public Execute getInstance_Execute()
		{
			return this.execute;
		}
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Control/Execute
        public Control_Execute getInstance_Control_Execute()
        {
            return this.getInstance_Execute().getInstance_Control_Execute();
        }

    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Wrapper
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
// TIER ALPHA (Top) :: Static_XxxxxxXxxxxx
             //this;
	
    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Algorithms	
        private Algorithms algorithms;    
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Control
    	private Control control;	
       
    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Data
        private Data data;    
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Control/Data
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Data/Input
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Data/Input
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/Concurrent_InputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/PraiseBuffer
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/PreMadeEmptyInputPraiseBuffer
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Input/Stack_InputPraise
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Data/Output
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Data/Output
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/Concurrent_OutputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/PraiseBuffer
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/PreMadeEmptyOutputPraiseBuffer
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Data/Output/Stack_OutputPraise
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Static_XxxxxxXxxxxx/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Execute
        private Execute execute;
        // TIER CHARLIE (Top - 2) :: Static_XxxxxxXxxxxx/Control/Execute

    // TIER BRAVO (Top - 1) :: Static_XxxxxxXxxxxx/Wrapper
        private TerminalWrapper wrapper;

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------

    }
    public class Dynamic_XxxxxxXxxxxxx 
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
        public Dynamic_XxxxxxXxxxxxx(Static_XxxxxxXxxxxx static_obj, int num_implemented_cores)
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Dynamic_XxxxxxXxxxxxx
             //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Algorithms	
            this.algorithms = static_obj.getInstance_Algorithms();
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Control
        	this.control = static_obj.getInstance_Control();
       
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Data
            this.data = static_obj.getInstance_Data();
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Data
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Data/Input/Concurrent_InputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Data/Input/PraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Data/Input/PreMadeEmptyInputPraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Data/Input/Stack_InputPraise
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Output
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Output
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Data/Output/Concurrent_OutputRefferenceOfCore
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Data/Output/PraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Data/Output/PreMadeEmptyOutputPraiseBuffer
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Data/Output/Stack_OutputPraise
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Execute
            this.execute = static_obj.getInstance_Execute();
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Execute

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Wrapper
            this.wrapper = static_obj.getInstance_TerminalWrapper();
		
// HREADED CORES
            this.thread_WithCoreId = new System.Threading.Thread[num_implemented_cores];
			for(int coreId = 0; coreId < num_implemented_cores; coreId++) 
            {
                if(coreId == 0) this.thread_WithCoreId[coreId] = new System.Threading.Thread(()=>static_obj.getInstance_Execute().thread_IO_Loader_Simulation(this, coreId));
                else if(coreId > 0) this.thread_WithCoreId[coreId] = new System.Threading.Thread(()=>static_obj.getInstance_Execute().thread_Concurreny(this, coreId));
            }
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

            for(int index = 0; index < num_implemented_cores; index++) 
            {
                this.thread_WithCoreId[index].Start();
            }

		}
        ~Dynamic_XxxxxxXxxxxxx()
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Dynamic_XxxxxxXxxxxxx
             //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Algorithms	
            this.algorithms = null;
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Control
        	this.control = null;
       
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Data
            this.data = null;
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Data
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Input
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Ouput
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Output
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Execute
            this.execute = null;
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Execute

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Wrapper
            this.wrapper = null;
		
// HREADED CORES
            for(int index = 0; index < this.thread_WithCoreId.Length; index++) 
            {
                this.thread_WithCoreId[index] = null;
            }

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
// TIER ALPHA (Top) :: Dynamic_XxxxxxXxxxxxx
             //this;
	
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Algorithms	
        public Algorithms getInstance_Algorithms()
        {
            return this.algorithms;
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms
        public Control_Algorithms getInstance_Control_Algorithms()
        {
            return this.getInstance_Algorithms().getInstance_Control_Algorithms();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Algorithms/Concurrent
        public Algorithms_Concurrent getInstance_Algorithms_Concurrent(int index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index);
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms/Concurrent
        public Control_Algorithms_Concurrent getInstance_Control_Algorithms_Concurrent(int index)
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_Concurrent(index).getInstance_Control_Algorithms_Concurrent();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Algorithms/ListenRespond
        public Algorithms_ListenRespond getInstance_Algorithms_ListenRespnd()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms/ListenRespond
        public Control_Algorithms_ListenRespond getInstance_Control_Algorithms_ListenRespond()
        {
            return this.getInstance_Algorithms().getInstance_Algorithms_ListenRespond().getInstance_Control_Algorithms_ListenRespond();
        }

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Control
        public Control getInstance_Control()
        {
            return this.control;
        }
       
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Data
        public Data getInstance_Data()
        {
            return this.data;
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Data
        public Control_Data getInstance_Control_Data()
        {
            return this.getInstance_Data().getInstance_Control_Data();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Input
        public Data_Input getInstance_Data_Input()
        {
            return this.getInstance_Data().getInstance_Data_Input();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Input
        public Control_Data_Input getInstance_Control_Data_Input()
        {
            return this.getInstance_Data().getInstance_Control_Data_Input();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Ouput
        public Data_Output getInstance_Data_Output()
        {
            return this.getInstance_Data().getInstance_Data_Output();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Output
        public Control_Data_Output getInstance_Control_Data_Output()
        {
            return this.getInstance_Data().getInstance_Control_Data_Output();
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Reconnaissance
        public Data_Reconnaissance getInstance_Data_Reconnaissance()
        {
            return this.getInstance_Data().getInstance_Data_Reconnaissace();
        }
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Reconnaissance
        public Control_Data_Reconnaissance getInstance_Control_Data_Reconniassance()
        {
            return this.getInstance_Data().getInstance_Control_Data_Reconnaissace();
        }

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Execute
        public Execute getInstance_Execute()
        {
            return this.execute;
        }
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Execute
        public Control_Execute getInstance_Control_Execute()
        {
            return this.getInstance_Execute().getInstance_Control_Execute();
        } 

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Wrapper
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
// TIER ALPHA (Top) :: Dynamic_XxxxxxXxxxxxx
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Algorithms	
            private Algorithms algorithms;
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Algorithms//Concurrent
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms/Concurrent
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Algorithms/ListenRespond
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Algorithms/ListenRespond

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Control
        	private Control control;
       
    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Data
            private Data data;
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Data
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Input
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Input
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Ouput
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Output
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Data/Reconnaissance
            // TIER DELTA (Top - 3) :: Dynamic_XxxxxxXxxxxxx/Control/Data/Reconniassance

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Execute
            private Execute execute;
        // TIER CHARLIE (Top - 2) :: Dynamic_XxxxxxXxxxxxx/Control/Execute

    // TIER BRAVO (Top - 1) :: Dynamic_XxxxxxXxxxxxx/Wrapper
            private TerminalWrapper wrapper;

// THREADED CORES
	    private System.Threading.Thread[] thread_WithCoreId;


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------

    }
}
//End <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<