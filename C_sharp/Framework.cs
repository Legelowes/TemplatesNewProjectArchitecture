//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Terminal Wrapper : Script File.cs
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
namespace FLORENCE_DEVELOPERS_TEMPLATE
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
        public Framework()
        {
            this.framework_Static_XxxXxx = new Static_Xxx_Xxx();
            while(this.framework_Static_XxxXxx == null) { }
            this.framework_Dynamic_XxxXxx = new Dynamic_Xxx_Xxx(framework_Static_XxxXxx);
            while(this.framework_Dynamic_XxxXxx == null) { }
        }


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        public void stop_DynamicFramework_Server_Backend()
        {
            this.framework_Dynamic_XxxXxx = null;

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
        private Static_Xxx_Xxx framework_Static_XxxXxx;
        private Dynamic_Xxx_Xxx framework_Dynamic_XxxXxx;

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------Framework
        public Dynamic_Xxx_Xxx getDynamicFramework()
        {
            return this.framework_Dynamic_XxxXxx;
        }
        public Static_Xxx_Xxx getStaticFramework()
        {
            return this.framework_Static_XxxXxx;
        }
          
    }
    public class Static_Xxx_Xxx
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
        public Static_Xxx_Xxx()
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Static_Xxx_Xxx
             //this;
	
    // TIER BRAVO (Top - 1) :: Algorithms	
            this.static_Algorithms = new FLORENCE_DEVELOPERS_TEMPLATE.Algorithms();

    // TIER BRAVO (Top - 1) :: Control
    		this.static_Control = new FLORENCE_DEVELOPERS_TEMPLATE.Control();
        // TIER CHARLIE (Top - 2) :: Control/Execute
            this.static_Control_Execute = new FLORENCE_DEVELOPERS_TEMPLATE.Control_Execute();
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
            this.static_Control_Algorithms = new FLORENCE_DEVELOPERS_TEMPLATE.Control_Algorithms();
        // TIER CHARLIE (Top - 2) :: Control/Data
            this.static_Control_Data = new FLORENCE_DEVELOPERS_TEMPLATE.Control_Data();
            // TIER DELTA (Top - 3) :: Control/Data/Input
            this.static_Control_Data_Input = new FLORENCE_DEVELOPERS_TEMPLATE.Control_Data_Input();
            // TIER DELTA (Top - 3) :: Control/Data/Output
            this.static_Control_Data_Output = new FLORENCE_DEVELOPERS_TEMPLATE.Control_Data_Output();
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance
            this.static_Control_Data_Reconnaissance = new FLORENCE_DEVELOPERS_TEMPLATE.Control_Data_Reconnaissance();
    
    // TIER BRAVO (Top - 1) :: Data
            this.static_Data = new FLORENCE_DEVELOPERS_TEMPLATE.Data();
        // TIER CHARLIE (Top - 2) :: Data/Input
            this.static_Data_Input = new FLORENCE_DEVELOPERS_TEMPLATE.Data_Input();
        // TIER CHARLIE (Top - 2) :: Data/Ouput
			this.static_Data_Output = new FLORENCE_DEVELOPERS_TEMPLATE.Data_Output();
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
            this.static_Data_Reconnaissance = new FLORENCE_DEVELOPERS_TEMPLATE.Data_Reconnaissance();
    
    // TIER BRAVO (Top - 1) :: Execute	
            this.static_Execute = new FLORENCE_DEVELOPERS_TEMPLATE.Execute();
    
    // TIER BRAVO (Top - 1) :: Wrapper
            this.static_Wrapper = new FLORENCE_DEVELOPERS_TEMPLATE.TerminalWrapper();
    
        }
        ~Static_Xxx_Xxx()
        {

        }

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------
// INSTANCE(S)
	// TIER BRAVO (Top - 1) :: Algorithms	
        public Algorithms getStatic_Algorithms()
		{
			return this.static_Algorithms;
		}

    // TIER BRAVO (Top - 1) :: Control
    	public Control getStatic_Control()
		{
			return this.static_Control;
		}
        // TIER CHARLIE (Top - 2) :: Control/Execute
            public Control_Execute getStatic_Control_Execute()
            {
                return this.static_Control_Execute;
            }
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
            public Control_Algorithms getStatic_Control_Algorithms()
            {
                return this.static_Control_Algorithms;
            }
        // TIER CHARLIE (Top - 2) :: Control/Data
            public Control_Data getStatic_Control_Data()
            {
                return this.static_Control_Data;
            }
            // TIER DELTA (Top - 3) :: Control/Data/Input
                public Control_Data_Input getStatic_Control_Data_Input()
                {
                    return this.static_Control_Data_Input;
                }
            // TIER DELTA (Top - 3) :: Control/Data/Output    
                public Control_Data_Output getStatic_Control_Data_Output()
                {
                    return this.static_Control_Data_Output;
                }
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance    
                public Control_Data_Reconnaissance getStatic_Control_Data_Reconnaissance()
                {
                    return this.static_Control_Data_Reconnaissance;
                }

    // TIER BRAVO (Top - 1) :: Data
        public Data getStatic_Data()
		{
			return this.static_Data;
		}
        // TIER CHARLIE (Top - 2) :: Data/Input
            public Data_Input getStatic_Data_Input()
		    {
			    return this.static_Data_Input;
		    }
        // TIER CHARLIE (Top - 2) :: Data/Ouput
            public Data_Output getStatic_Data_Output()
		    {
			    return this.static_Data_Output;
		    }
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
            public Data_Reconnaissance getStatic_Data_Reconnaissance()
		    {
			    return this.static_Data_Reconnaissance;
		    }

    // TIER BRAVO (Top - 1) :: Execute	
		public Execute getStatic_Execute()
		{
			return this.static_Execute;
		}

    // TIER BRAVO (Top - 1) :: Wrapper
        public TerminalWrapper getStatic_TerminalWrapper()
		{
			return this.static_Wrapper;
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
    // TIER BRAVO (Top - 1) :: Algorithms	
        private Algorithms static_Algorithms;
                
    // TIER BRAVO (Top - 1) :: Control
    	private Control static_Control;
        // TIER CHARLIE (Top - 2) :: Control/Execute
            private Control_Execute static_Control_Execute;
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
            private Control_Algorithms static_Control_Algorithms;
        // TIER CHARLIE (Top - 2) :: Control/Data
            private Control_Data static_Control_Data;
            // TIER DELTA (Top - 3) :: Control/Data/Input
                private Control_Data_Input static_Control_Data_Input;
            // TIER DELTA (Top - 3) :: Control/Data/Output
                private Control_Data_Output static_Control_Data_Output;
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance
                private Control_Data_Reconnaissance static_Control_Data_Reconnaissance;

    // TIER BRAVO (Top - 1) :: Data
        private Data static_Data;
        // TIER CHARLIE (Top - 2) :: Data/Input
            private Data_Input static_Data_Input;
        // TIER CHARLIE (Top - 2) :: Data/Ouput
		    private Data_Output static_Data_Output;
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
            private Data_Reconnaissance static_Data_Reconnaissance;

	// TIER BRAVO (Top - 1) :: Execute	
        private Execute static_Execute;

    // TIER BRAVO (Top - 1) :: Wrapper
        private TerminalWrapper static_Wrapper;

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------

    }
    public class Dynamic_Xxx_Xxx
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
        public Dynamic_Xxx_Xxx(Static_Xxx_Xxx static_obj)
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Static_Xxx_Xxx
            //Dynamic_Xxx_Xxx framework_Dynamic_XxxXxx;

    // TIER BRAVO (Top - 1) :: Algorithms	
            this.algorithms = static_obj.getStatic_Algorithms();

    // TIER BRAVO (Top - 1) :: Control
    	    this.control = static_obj.getStatic_Control();
        // TIER CHARLIE (Top - 2) :: Control/Execute
            this.control_Execute = static_obj.getStatic_Control_Execute();        
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
            this.control_Algorithms = static_obj.getStatic_Control_Algorithms();    
        // TIER CHARLIE (Top - 2) :: Control/Data
            this.control_Data = static_obj.getStatic_Control_Data();        
            // TIER DELTA (Top - 3) :: Control/Data/Input
            this.control_Data_Input = static_obj.getStatic_Control_Data_Input();        
            // TIER DELTA (Top - 3) :: Control/Data/Output
            this.control_Data_Output = static_obj.getStatic_Control_Data_Output();        
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance
            this.control_Data_Reconniassance = static_obj.getStatic_Control_Data_Reconnaissance();

    // TIER BRAVO (Top - 1) :: Data
            this.data = static_obj.getStatic_Data();
        // TIER CHARLIE (Top - 2) :: Data/Input
                this.data_Input = static_obj.getStatic_Data_Input();
        // TIER CHARLIE (Top - 2) :: Data/Ouput
		        this.data_Output = static_obj.getStatic_Data_Output();
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
                this.data_Reconnaissance = static_obj.getStatic_Data_Reconnaissance();

	// TIER BRAVO (Top - 1) :: Execute	
            this.execute = static_obj.getStatic_Execute();

    // TIER BRAVO (Top - 1) :: Wrapper
            this.terminalWrapper = static_obj.getStatic_TerminalWrapper();
		
// HREADED CORES
			this.td_IO_Loader_Simulation = new Thread(()=>static_obj.getStatic_Execute().td_IO_Loader_Simulation(this));
			this.td_Concurreny_0 = new Thread(()=>static_obj.getStatic_Execute().td_Concurreny(this));
			this.td_Concurreny_1 = new Thread(()=>static_obj.getStatic_Execute().td_Concurreny(this));

            checkList_PriorToConcurrentLaunch(static_obj, this);

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
        ~Dynamic_Xxx_Xxx()
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Static_Xxx_Xxx
            //Dynamic_Xxx_Xxx framework_Dynamic_XxxXxx;

    // TIER BRAVO (Top - 1) :: Algorithms	
            this.algorithms = null;
    // TIER BRAVO (Top - 1) :: Control
    	    this.control = null;
        // TIER CHARLIE (Top - 2) :: Control/Execute
            this.control_Execute = null;
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
            this.control_Algorithms = null;
        // TIER CHARLIE (Top - 2) :: Control/Data
            this.control_Data = null;
            // TIER DELTA (Top - 3) :: Control/Data/Input
            this.control_Data_Input = null;
            // TIER DELTA (Top - 3) :: Control/Data/Output
            this.control_Data_Output = null;
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance
            this.control_Data_Reconniassance = null;

    // TIER BRAVO (Top - 1) :: Data
            this.data = null;
        // TIER CHARLIE (Top - 2) :: Data/Input
                this.data_Input = null;
        // TIER CHARLIE (Top - 2) :: Data/Ouput
		        this.data_Output = null;
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
                this.data_Reconnaissance = null;

	// TIER BRAVO (Top - 1) :: Execute	
            this.execute = null;

    // TIER BRAVO (Top - 1) :: Wrapper
            this.terminalWrapper = null;
		
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
    // TIER BRAVO (Top - 1) :: Algorithms	
        private Algorithms getDynamic_Algorithms()
        {
            return this.algorithms;
        }

    // TIER BRAVO (Top - 1) :: Control
        private Control getDynamic_Control()
        {
            return this.control;
        }
        // TIER CHARLIE (Top - 2) :: Control/Execute
            private Control_Execute getDynamic_Control_Execute()
            {
                return this.control_Execute;
            }        
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
            private Control_Algorithms getDynamic_Control_Algorithms()
            {
                return this.control_Algorithms;
            } 
        // TIER CHARLIE (Top - 2) :: Control/Data
            private Control_Data getDynamic_Control_Data()
            {
                return this.control_Data;
            }
            // TIER DELTA (Top - 3) :: Control/Data/Input
                private Control_Data_Input getDynamic_Control_Data_Input()
                {
                    return this.control_Data_Input;
                }        
            // TIER DELTA (Top - 3) :: Control/Data/Output
                private Control_Data_Output getDynamic_Control_Data_Output()
                {
                    return this.control_Data_Output;
                }        
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance
                private Control_Data_Reconnaissance getDynamic_Control_Data_Reconniassance()
                {
                    return this.control_Data_Reconniassance;
                }

    // TIER BRAVO (Top - 1) :: Data
        private Data getDynamic_Data()
        {
            return this.data;
        }
        // TIER CHARLIE (Top - 2) :: Data/Input
            private Data_Input getDynamic_Data_Input()
        {
            return this.data_Input;
        }
        // TIER CHARLIE (Top - 2) :: Data/Ouput
		    private Data_Output getDynamic_Data_Output()
        {
            return this.data_Output;
        }
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
            private Data_Reconnaissance getDynamic_Data_Reconnaissance()
        {
            return this.data_Reconnaissance;
        }

	// TIER BRAVO (Top - 1) :: Execute	
        private Execute getDynamic_Execute()
        {
            return this.execute;
        }

    // TIER BRAVO (Top - 1) :: Wrapper
        private TerminalWrapper getDynamic_TerminalWrapper()
        {
            return this.terminalWrapper;
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
    // TIER BRAVO (Top - 1) :: Algorithms	
        private Algorithms algorithms;

    // TIER BRAVO (Top - 1) :: Control
        private Control control;
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
            private Control_Algorithms control_Algorithms;
        // TIER CHARLIE (Top - 2) :: Control/Data
            private Control_Data control_Data;        
            // TIER DELTA (Top - 3) :: Control/Data/Input
                private Control_Data_Input control_Data_Input;        
            // TIER DELTA (Top - 3) :: Control/Data/Output
                private Control_Data_Output control_Data_Output;        
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance
                private Control_Data_Reconnaissance control_Data_Reconniassance;
        // TIER CHARLIE (Top - 2) :: Control/Execute
            private Control_Execute control_Execute;        

    // TIER BRAVO (Top - 1) :: Data
        private Data data;
        // TIER CHARLIE (Top - 2) :: Data/Input
            private Data_Input data_Input;
        // TIER CHARLIE (Top - 2) :: Data/Ouput
		    private Data_Output data_Output;
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
            private Data_Reconnaissance data_Reconnaissance;

	// TIER BRAVO (Top - 1) :: Execute	
        private Execute execute;

    // TIER BRAVO (Top - 1) :: Wrapper
        private TerminalWrapper terminalWrapper;


// THREADED CORES
	    private System.Threading.Thread td_IO_Loader_Simulation;
	    private System.Threading.Thread td_Concurreny_0;
	    private System.Threading.Thread td_Concurreny_1;


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        private bool checkList_PriorToConcurrentLaunch(Static_Xxx_Xxx obj_Static, Dynamic_Xxx_Xxx obj_Dynamic)
        {
            bool checkBit_PASS = false;
            if(check_Static_ColdStart(obj_Static) == true){
                if(check_Dynamic_ColdStart(obj_Dynamic) == true){
                    checkBit_PASS = true;
                }
            }
            return checkBit_PASS;
        }
        private bool check_Dynamic_ColdStart(Dynamic_Xxx_Xxx obj_Dynamic)
        {
            bool checkBit_PASS = false;
            if(obj_Dynamic != null){
                if(obj_Dynamic.getDynamic_Algorithms() != null){
                    if(obj_Dynamic.getDynamic_Control() != null){
                        if(obj_Dynamic.getDynamic_Control_Algorithms() != null){
                            if(obj_Dynamic.getDynamic_Control_Data() != null){
                                if(obj_Dynamic.getDynamic_Control_Data_Input() != null){
                                    if(obj_Dynamic.getDynamic_Control_Data_Output() != null){
                                        if(obj_Dynamic.getDynamic_Control_Data_Reconniassance() != null){
                                            if(obj_Dynamic.getDynamic_Control_Execute() != null){
                                                if(obj_Dynamic.getDynamic_Data() != null){
                                                    if(obj_Dynamic.getDynamic_Data_Input() != null){
                                                        if(obj_Dynamic.getDynamic_Data_Output() != null){
                                                            if(obj_Dynamic.getDynamic_Data_Reconnaissance() != null){
                                                                if(obj_Dynamic.getDynamic_Execute() != null){
                                                                    if(obj_Dynamic.getDynamic_TerminalWrapper() != null){
                                                                        checkBit_PASS = true;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return checkBit_PASS;
        }
        private bool check_Static_ColdStart(Static_Xxx_Xxx obj_Static)
        {
            bool checkBit_PASS = false;
            if(obj_Static != null){
                if(obj_Static.getStatic_Algorithms() != null){
                    if(obj_Static.getStatic_Control() != null){
                        if(obj_Static.getStatic_Control_Algorithms() != null){
                            if(obj_Static.getStatic_Control_Data() != null){
                                if(obj_Static.getStatic_Control_Data_Input() != null){
                                    if(obj_Static.getStatic_Control_Data_Output() != null){
                                        if(obj_Static.getStatic_Control_Data_Reconnaissance() != null){
                                            if(obj_Static.getStatic_Control_Execute() != null){
                                                if(obj_Static.getStatic_Data() != null){
                                                    if(obj_Static.getStatic_Data_Input() != null){
                                                        if(obj_Static.getStatic_Data_Output() != null){
                                                            if(obj_Static.getStatic_Data_Reconnaissance() != null){
                                                                if(obj_Static.getStatic_Execute() != null){
                                                                    if(obj_Static.getStatic_TerminalWrapper() != null){
                                                                        checkBit_PASS = true;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return checkBit_PASS;
        }
//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------


    }
}
//End <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<