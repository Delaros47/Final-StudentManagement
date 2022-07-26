using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.UserControls.Controls
{
    //When we try to Implement out DataLayoutControl it doesn't happen in our project on Form we just add a DataLayoutContol then it adds dll in our project then we delete it now we can implement from it
    [ToolboxItem(true)]
    public class MyDataLayoutControl:DataLayoutControl
    {
        public MyDataLayoutControl()
        {
            //We want to make our own Tab Order beside default DataLayoutControl making
            OptionsFocus.EnableAutoTabOrder = false;
        }

        //Since we want to create our own DataLayoutControl as custom one so we have to override CreateILayoutControlImplementorCore then we could create our own Rows and Columns in DatalayoutControl
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            //CreateILayoutControlImplementorCore requires LayoutControlImplementor since we want to create our own so wrote MyLayoutControlImplementor and write this because return this control
            return new MyLayoutControlImplementor(this);
        }
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner controlOwner) : base(controlOwner)
        {

        }

        //This is our Group in DataLayoutContol means Rows and Columns
        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var group = base.CreateLayoutGroup(parent);
            //Here we convert our DataLayoutControl into Table one because we put textbox and in the same line we will add Toggle Switch as well that's why we converted into Table mode when we converted that it create two Columns and two Rows automatically
            group.LayoutMode = LayoutMode.Table;
            //Since it adds two Columns and Rows we will make it 3 columns and 10 rows 
            //Here we make our first Column as Absolute means that it is fixed that we cannot change width of it and we made our first Column Width 210 and second column we made it 100 but whenever we resize our DataLayout control width will get bigger with Percentange with 100% that's why we made it percent and we make it smaller our DatalayoutConrol our Percent group also will get smaller
            //Now Since manually Table Mode creates us two Columns that we will create the third one by ourselves with Absolute (fixed Width 92)

            group.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            group.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 210;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            group.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType=SizeType.Absolute,Width=92});

            //We have explained that manually Table Mode create two Columns and two Rows and now we delete our Rows we will create our own Rows 10 rows as custom
            group.OptionsTableLayoutGroup.RowDefinitions.Clear();

            for (int i = 1; i <= 10; i++)
            {
                group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition { SizeType=SizeType.Absolute,Height=24});
                if (i+1!=10)
                {
                    continue;
                }
                else
                {
                    group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition { SizeType=SizeType.Percent,Height=100});
                    break;
                }
            }

            return group;

        }

        //Here whenever we move any control in our Custom DataLayoutControl so we want to change the text color of ItemCaption
        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            return item;
        }
    }
}
