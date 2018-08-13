﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infra;
using Infra.Extensions;
using TNS.API.ApiDataObjects;
using TNS.BL;
using UILogic;

namespace TNS.Controls
{
    public partial class MainSecuritiesView : UserControl
    {
        public MainSecuritiesView()
        {
            InitializeComponent();
        }


        public void SetManagedSecuritiesData(List<SecurityData> securitiesDataList)
        {
            gridControl1.InvokeIfRequired(() =>
            {
                securityDataBindingSource.DataSource = securitiesDataList;
                securityDataBindingSource.ResetBindings(false);

            });

            GeneralTimer.GeneralTimerInstance.AddTask(TimeSpan.FromSeconds(1),
                () =>
                {
                    gridControl1.InvokeIfRequired(() =>
                    {
                        securityDataBindingSource.ResetBindings(false);

                    });
                },
                true);

        }




        //public MainSecuritiesView(UIDataManager uiDataManager) : this()
        //{
        //    UIDataManager = uiDataManager;
        //}

        //public void SetUIDataManager(UIDataManager uiDataManager)
        //{
        //    UIDataManager = uiDataManager;
        //    this.InvokeIfRequired(() =>
        //    {
        //        securityDataBindingSource.DataSource = UIDataManager.GetSecurityDataList();
        //        securityDataBindingSource.ResetBindings(false);
        //    });
        //    UIDataManager.SecuritiesUpdated += UIDataManagerOnSecuritiesUpdated;
        //}

        //private void UIDataManagerOnSecuritiesUpdated(BaseSecurityData securityData)
        //{
        //    this.InvokeIfRequired(() =>
        //    {
        //        securityDataBindingSource.DataSource = UIDataManager.GetSecurityDataList();
        //        securityDataBindingSource.ResetBindings(false);
        //    });
        //}

        //public UIDataManager UIDataManager { get; set; }
    }
}
