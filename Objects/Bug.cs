﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.uiu
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Bug.
    /// </summary>
    //  *** Start programmer edit section *** (Bug CustomAttributes)

    //  *** End programmer edit section *** (Bug CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("BugE", new string[0])]
    [View("BugL", new string[0])]
    public class Bug : ICSSoft.STORMNET.DataObject
    {
        
        //  *** Start programmer edit section *** (Bug CustomMembers)

        //  *** End programmer edit section *** (Bug CustomMembers)

        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "BugE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View BugE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("BugE", typeof(IIS.uiu.Bug));
                }
            }
            
            /// <summary>
            /// "BugL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View BugL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("BugL", typeof(IIS.uiu.Bug));
                }
            }
        }
    }
}
