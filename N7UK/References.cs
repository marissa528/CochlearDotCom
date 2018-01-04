﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace N7UK
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The References recording.
    /// </summary>
    [TestModule("39f5cf0e-3b73-4fe3-981a-e8712d12a1fa", ModuleType.Recording, 1)]
    public partial class References : ITestModule
    {
        /// <summary>
        /// Holds an instance of the N7UKRepository repository.
        /// </summary>
        public static N7UKRepository repo = N7UKRepository.Instance;

        static References instance = new References();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public References()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static References Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.hearyourway.com/wps/wcm/connect/uk/n7/home' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            //Host.Current.OpenBrowser("http://www.hearyourway.com/wps/wcm/connect/uk/n7/home", "chrome", "", false, false, false, false, false);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Parent'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo, new RecordItemIndex(1));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'CochlearImplantSoundProcessorNucleus' at 1908;214.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(2));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1908;214");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'CochlearImplantSoundProcessorNucleus' at 1901;631.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(3));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1901;631");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.References'.", repo.CochlearImplantSoundProcessorNucleus.ReferencesInfo, new RecordItemIndex(4));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ReferencesInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.HttpsSupportAppleComEnAuHT201466' at 201;4.", repo.CochlearImplantSoundProcessorNucleus.HttpsSupportAppleComEnAuHT201466Info, new RecordItemIndex(5));
            repo.CochlearImplantSoundProcessorNucleus.HttpsSupportAppleComEnAuHT201466.Click("201;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'UseMadeForIPhoneHearingAidsApple' at 1911;663.", repo.UseMadeForIPhoneHearingAidsApple.SelfInfo, new RecordItemIndex(6));
            repo.UseMadeForIPhoneHearingAidsApple.Self.MoveTo("1911;663");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'UseMadeForIPhoneHearingAidsApple' at 1912;624.", repo.UseMadeForIPhoneHearingAidsApple.SelfInfo, new RecordItemIndex(7));
            repo.UseMadeForIPhoneHearingAidsApple.Self.MoveTo("1912;624");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'UseMadeForIPhoneHearingAidsApple.CompatibleHearingDevices'.", repo.UseMadeForIPhoneHearingAidsApple.CompatibleHearingDevicesInfo, new RecordItemIndex(8));
            Validate.Exists(repo.UseMadeForIPhoneHearingAidsApple.CompatibleHearingDevicesInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UseMadeForIPhoneHearingAidsApple1' at 484;29.", repo.UseMadeForIPhoneHearingAidsApple1.SelfInfo, new RecordItemIndex(9));
            repo.UseMadeForIPhoneHearingAidsApple1.Self.Click("484;29");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.FluidContainer.SpanTagParent'.", repo.CochlearImplantSoundProcessorNucleus.FluidContainer.SpanTagParentInfo, new RecordItemIndex(10));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.FluidContainer.SpanTagParentInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
