//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Terminal Wrapper : Script File.cs
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
namespace FLORENCE_NameSpace
{
    public class Static_XXXXXX
    {
//	PUBLIC -==============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
		public void initialise_StaticFramework_XxxXxx()
		{
// INSTANCE(S)
// TIER ALPHA (Top) :: Static_XXXXXX
            Static_XXXXXX obj = this;
	// TIER BRAVO (Top - 1) :: Execute	
            obj.static_Execute = new FLORENCE_NameSpace.Execute();
        // TIER CHARLIE (Top - 2) :: Execute/???
            /* TODO>
            *
            */

    // TIER BRAVO (Top - 1) :: Control
    		obj.static_Control = new FLORENCE_NameSpace.Control();
        // TIER CHARLIE (Top - 2) :: Control/Execute
            obj.static_Control_Execute = new FLORENCE_NameSpace.Control_Execute();
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
            obj.static_Control_Algorithms = new FLORENCE_NameSpace.Control_Algorithms();
        // TIER CHARLIE (Top - 2) :: Control/Data
            obj.static_Control_Data = new FLORENCE_NameSpace.Control_Data();
            // TIER DELTA (Top - 3) :: Control/Data/Input
            obj.static_Control_Data_Input = new FLORENCE_NameSpace.Control_Data_Input();
            // TIER DELTA (Top - 3) :: Control/Data/Output
            obj.static_Control_Data_Output = new FLORENCE_NameSpace.Control_Data_Output();
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance
            obj.static_Control_Data_Reconnaissance = new FLORENCE_NameSpace.Control_Data_Reconnaissance();
            /* TODO>
            *
            */

    // TIER BRAVO (Top - 1) :: Algorithms	
            obj.static_Algorithms = new FLORENCE_NameSpace.Algorithms();
        // TIER CHARLIE (Top - 2) :: Algorithms/???
            /* TODO>
            *
            */

    // TIER BRAVO (Top - 1) :: Data
            obj.static_Data = new FLORENCE_NameSpace.Data();
        // TIER CHARLIE (Top - 2) :: Data/Input
            obj.static_Data_Input = new FLORENCE_NameSpace.Data_Input();
        // TIER CHARLIE (Top - 2) :: Data/Ouput
			obj.static_Data_Output = new FLORENCE_NameSpace.Data_Output();
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
            obj.static_Data_Reconnaissance = new FLORENCE_NameSpace.Data_Reconnaissance();
    // TIER BRAVO (Top - 1) :: Wrapper
            obj.static_Wrapper = new FLORENCE_NameSpace.TerminalWrapper();
        // TIER CHARLIE (Top - 2) :: Wrapper/???
            /* TODO>
            *
            */

        }
//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------
// INSTANCE(S)
	// TIER BRAVO (Top - 1) :: Execute	
		public Execute getStatic_Execute()
		{
			return this.static_Execute;
		}
        // TIER CHARLIE (Top - 2) :: Execute/???
            /* TODO>
            *
            */

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
                /* TODO>
                *
                */

    // TIER BRAVO (Top - 1) :: Algorithms	
        public Algorithms getStatic_Algorithms()
		{
			return this.static_Algorithms;
		}
        // TIER CHARLIE (Top - 2) :: Algorithms/???
            /* TODO>
            *
            */
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
    // TIER BRAVO (Top - 1) :: Wrapper
        public TerminalWrapper getStatic_TerminalWrapper()
		{
			return this.static_Wrapper;
		}
        // TIER CHARLIE (Top - 2) :: Wrapper/???
            /* TODO>
            *
            */


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
	// TIER BRAVO (Top - 1) :: Execute	
        private Execute static_Execute;
        // TIER CHARLIE (Top - 2) :: Execute/???
            /* TODO>
            *
            */

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

    // TIER BRAVO (Top - 1) :: Algorithms	
        private Algorithms static_Algorithms;
        // TIER CHARLIE (Top - 2) :: Execute/???
            /* TODO>
            *
            */

    // TIER BRAVO (Top - 1) :: Data
        private Data static_Data;
        // TIER CHARLIE (Top - 2) :: Data/Input
            private Data_Input static_Data_Input;
        // TIER CHARLIE (Top - 2) :: Data/Ouput
		    private Data_Output static_Data_Output;
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
            private Data_Reconnaissance static_Data_Reconnaissance;

    // TIER BRAVO (Top - 1) :: Wrapper
        private TerminalWrapper static_Wrapper;
        // TIER CHARLIE (Top - 2) :: Wrapper/???
            /* TODO>
            *
            */

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------

    }
    public class Dynamic_XXXXXX
    {
//	PUBLIC -==============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

        public Dynamic_XXXXXX(Static_XXXXXX static_obj)
        {
// INSTANCE(S)
// TIER ALPHA (Top) :: Static_XXXXXX
            Dynamic_XXXXXX obj = this;
	// TIER BRAVO (Top - 1) :: Execute	
            obj.execute = static_obj.getStatic_Execute();
        // TIER CHARLIE (Top - 2) :: Execute/???
            /* TODO>
            *
            */
    // TIER BRAVO (Top - 1) :: Control
    	    obj.control = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Control();
        // TIER CHARLIE (Top - 2) :: Control/Execute
            obj.control_Execute = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Control_Execute();        
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
            obj.control_Algorithms = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Control_Algorithms();    
        // TIER CHARLIE (Top - 2) :: Control/Data
            obj.control_Data = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Control_Data();        
            // TIER DELTA (Top - 3) :: Control/Data/Input
            obj.control_Data_Input = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Control_Data_Input();        
            // TIER DELTA (Top - 3) :: Control/Data/Output
            obj.control_Data_Output = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Control_Data_Output();        
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance
            obj.control_Data_Reconniassance = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Control_Data_Reconnaissance();
            /* TODO>
            *
            */
    // TIER BRAVO (Top - 1) :: Algorithms	
            obj.algorithms = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Algorithms();
        // TIER CHARLIE (Top - 2) :: Algorithms/???
            /* TODO>
            *
            */
    // TIER BRAVO (Top - 1) :: Data
            obj.data = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Data();
        // TIER CHARLIE (Top - 2) :: Data/Input
                obj.data_Input = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Data_Input();
        // TIER CHARLIE (Top - 2) :: Data/Ouput
		        obj.data_Output = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Data_Output();
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
                obj.data_Reconnaissance = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_Data_Reconnaissance();
    // TIER BRAVO (Top - 1) :: Wrapper
            obj.terminalWrapper = new FLORENCE_NameSpace.Static_XXXXXX.getStatic_TerminalWrapper();
        // TIER CHARLIE (Top - 2) :: Wrapper/???
            /* TODO>
            *
            */
    }
//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

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
// INSTANCE(S)
	// TIER BRAVO (Top - 1) :: Execute	
    private Execute execute;
        // TIER CHARLIE (Top - 2) :: Execute/???
        /* TODO>
        *
        */

    // TIER BRAVO (Top - 1) :: Control
    private Control control;
        // TIER CHARLIE (Top - 2) :: Control/Execute
        private Control control_Execute;        
        // TIER CHARLIE (Top - 2) :: Control/Algorithms
        private Control control_Algorithms;    
        // TIER CHARLIE (Top - 2) :: Control/Data
        private Control control_Data;        
            // TIER DELTA (Top - 3) :: Control/Data/Input
            private Control control_Data_Input;        
            // TIER DELTA (Top - 3) :: Control/Data/Output
            private Control control_Data_Output;        
            // TIER DELTA (Top - 3) :: Control/Data/Reconnaissance
            private Control control_Data_Reconniassance;
        /* TODO>
        *
        */

    // TIER BRAVO (Top - 1) :: Algorithms	
    private Algorithms algorithms;
        // TIER CHARLIE (Top - 2) :: Algorithms/???
        /* TODO>
        *
        */

    // TIER BRAVO (Top - 1) :: Data
    private Data data;
        // TIER CHARLIE (Top - 2) :: Data/Input
        private Data_Input data_Input;
        // TIER CHARLIE (Top - 2) :: Data/Ouput
		 private Data_Output data_Output;
        // TIER CHARLIE (Top - 2) :: Data/Reconnaissance
        private Data_Reconnaissance data_Reconnaissance;
        /* TODO>
        *
        */

    // TIER BRAVO (Top - 1) :: Wrapper
     private TerminalWrapper terminanlWrapper;
        // TIER CHARLIE (Top - 2) :: Wrapper/???
        /* TODO>
        *
        */

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************

//	GET & SET --------------------------------------------------------------------------------------------------------------------------------------------


    }
}
//End <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<