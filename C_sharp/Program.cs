﻿//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Program - Main : Framework - EXECUTE First : Script File.cs
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
namespace FLORENCE_Server_ClientServerAssembly   
{
    class Program 
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
//	STATIC -----------------------------------------------------------------------------------------------------------------------------------------------
        public static void Main(string[] args)
        {
            System.Console.WriteLine(">> >> >> ENTERED : Program/Main");//SIMULATION
            System.Console.WriteLine("******************************************************************************************************************************************************");//SIMULATION
            sbyte num_Comcurrent_Cores = 2;
            Framework server_CLientServerAssembly = new Framework(num_Comcurrent_Cores);
            System.Console.WriteLine("DEFINTITION of Static Script COMPLETE");//SIMULATION            
            System.Console.WriteLine("INITALISATION of Static Instances COMPLETE");//SIMULATION
            System.Console.WriteLine("DECLARATION of Dynamic Architecture COMPLETE");//SIMULATION
            System.Console.WriteLine("INSTANCIATION of Dynamic Architecture COMPLETE");//SIMULATION
            System.Console.WriteLine("LAUNCH of CONCURRENT Dynamic Architecture COMPLETE");//SIMULATION

            System.Console.WriteLine("SIMULATION TESTBECH>START ****************************************************************************************************************************");//SIMULATION
            // TODO TESTBECH WORKLOAD
            /* 
            *
            */
            System.Console.WriteLine("SIMULATION TESTBECH>END ******************************************************************************************************************************");//SIMULATION
            
            Program.server_CLientServerAssembly.stop_DynamicFramework_Server_Backend();
            System.Console.WriteLine("<< << << EXITING : Program/Main");//SIMULATION
        }

	//	GET & SET ----------------------------------------------------------------------------------------------------------------------------------------

//	DYNAMIC ----------------------------------------------------------------------------------------------------------------------------------------------

	//	GET & SET ----------------------------------------------------------------------------------------------------------------------------------------



//	PROTECTED ============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
//	STATIC -----------------------------------------------------------------------------------------------------------------------------------------------

	//	GET & SET ----------------------------------------------------------------------------------------------------------------------------------------

//	DYNAMIC ----------------------------------------------------------------------------------------------------------------------------------------------

	//	GET & SET ----------------------------------------------------------------------------------------------------------------------------------------



//	PRIVATE ==============================================================================================================================================
//  ======================================================================================================================================================
//  ======================================================================================================================================================
//	CONSTANTS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************


//	REGISTERS ********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
        private static Framework server_CLientServerAssembly = new Framework(2);
        private static sbyte num_Comcurrent_Cores = new sbyte();

//	METHODS **********************************************************************************************************************************************
// 	******************************************************************************************************************************************************
//	STATIC -----------------------------------------------------------------------------------------------------------------------------------------------

	//	GET & SET ----------------------------------------------------------------------------------------------------------------------------------------


//	DYNAMIC ----------------------------------------------------------------------------------------------------------------------------------------------

	//	GET & SET ----------------------------------------------------------------------------------------------------------------------------------------

    }
}
//End <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<