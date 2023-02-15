using My_Bikes_Store.business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace My_Bikes_Store
{
    public partial class Form1 : Form
    {

        //###################################################################
        //Data mamber

        List<Bike> listOfBikes = new List<Bike>();
        int index = -1;

        //###################################################################
        public Form1()
        {
            InitializeComponent();
        }


        //########################################################
        private void Form1_Load(object sender, EventArgs e)
        {

            this.combo_type.Items.Add("Road Bike");
            this.combo_type.Items.Add("Mountain Bike");
            this.combo_type.Items.Add("Electric Bike");
            this.combo_type.Text = "Road Bike";

            this.combo_abs.Items.Add("Yes");
            this.combo_abs.Items.Add("No");
            this.combo_abs.Text = "Yes";

            this.combo_charge.Items.Add("Yes");
            this.combo_charge.Items.Add("No");
            this.combo_charge.Text = "Yes";

            this.combo_range.Items.Add("Yes");
            this.combo_range.Items.Add("No");
            this.combo_range.Text = "Yes";


            foreach (EnumColor elemnt in Enum.GetValues(typeof(EnumColor)))
            {
                this.combo_color.Items.Add(elemnt);
            }
            this.combo_color.Text = Convert.ToString(EnumColor.Blue);

            foreach (EnumSuspension elemnt in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.combo_suspension.Items.Add(elemnt);
            }
            this.combo_suspension.Text = Convert.ToString(EnumSuspension.Front);

        }

        //########################################################
        private void btn_remove_Click(object sender, EventArgs e)
        {
            string[] words = this.listBox1.SelectedItem.ToString().Split('|');

            //Using for each to make sure that user would be able to delete an item 
            //even if listBox shows only RoadBikes or MountainBikes
            foreach (Bike item in listOfBikes)
            {
                if (item.Serial_number == Convert.ToDouble(words[1]))
                {
                    this.listOfBikes.Remove(item);
                    break;
                }
            }

            

            MessageBox.Show("​Item deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_print_Click(sender, e);
        }

        //########################################################

        private void addRoadBike() 
        {

            RoadBike newBike = new RoadBike();

            bool t1 = Validator.CheckSerialNumber(this.tbox_serialNumber.Text);
            bool t2 = Validator.CheckMake(this.tbox_make.Text);
            bool t3 = Validator.CheckSpeed(this.tbox_speed.Text);
            bool t4 = Validator.CheckHeightFromGround(this.tbox_heightFromGround.Text);

            if (t1 && t2 && t3 && t4)
            {
                EnumColor tempColor;
                Enum.TryParse(combo_color.Text, out tempColor);
                newBike.Color = tempColor;

                EnumSuspension tempSus;
                Enum.TryParse(combo_suspension.Text, out tempSus);
                newBike.Suspension = tempSus;

                newBike.HeightFromGround = Convert.ToDouble(this.tbox_heightFromGround.Text);
                newBike.Make = this.tbox_make.Text;
                newBike.Serial_number = Convert.ToInt64(this.tbox_serialNumber.Text);
                newBike.Speed = Convert.ToDouble(this.tbox_speed.Text);
                newBike.Date = this.dateTimePicker1.Value;

                if (this.combo_abs.Text == "Yes")
                {
                    newBike.AbsSupport = true;
                }
                else
                {
                    newBike.AbsSupport = false;
                }

                listOfBikes.Add(newBike);

                MessageBox.Show("​Item added to to list successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please Check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void addMountainBike()
        {

            MountainBike newBike = new MountainBike();

            bool t1 = Validator.CheckSerialNumber(this.tbox_serialNumber.Text);
            bool t2 = Validator.CheckMake(this.tbox_make.Text);
            bool t3 = Validator.CheckSpeed(this.tbox_speed.Text);
            bool t4 = Validator.CheckTiresSize(this.tbox_tireSize.Text);
            bool t5 = Validator.CheckSeatHeight(this.tbox_seatHeight.Text);
            
            if (t1 && t2 && t3 && t4 && t5)
            {
                EnumColor tempColor;
                Enum.TryParse(combo_color.Text, out tempColor);
                newBike.Color = tempColor;

                newBike.Make = this.tbox_make.Text;
                newBike.Serial_number = Convert.ToInt64(this.tbox_serialNumber.Text);
                newBike.Speed = Convert.ToDouble(this.tbox_speed.Text);
                newBike.Date = this.dateTimePicker1.Value;
                newBike.SeatHeight = Convert.ToDouble(this.tbox_seatHeight.Text);

                listOfBikes.Add(newBike);
                MessageBox.Show("​Item added to to list successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void addElectricBike()
        {

            ElectricBike newBike = new ElectricBike();

            bool t1 = Validator.CheckSerialNumber(this.tbox_serialNumber.Text);
            bool t2 = Validator.CheckMake(this.tbox_make.Text);
            bool t3 = Validator.CheckSpeed(this.tbox_speed.Text);

            if (t1 && t2 && t3)
            {
                EnumColor tempColor;
                Enum.TryParse(combo_color.Text, out tempColor);
                newBike.Color = tempColor;


                newBike.Make = this.tbox_make.Text;
                newBike.Serial_number = Convert.ToInt64(this.tbox_serialNumber.Text);
                newBike.Speed = Convert.ToDouble(this.tbox_speed.Text);
                newBike.Date = this.dateTimePicker1.Value;

                if (this.combo_range.Text == "Yes")
                {
                    newBike.LongRange = true;
                }
                else
                {
                    newBike.LongRange = false;
                }

                if (this.combo_charge.Text == "Yes")
                {
                    newBike.QuickCharger = true;
                }
                else
                {
                    newBike.QuickCharger = false;
                }

                listOfBikes.Add(newBike);

                MessageBox.Show("​Item added to to list successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please Check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            if (this.combo_type.Text == "Road Bike")
            {
                addRoadBike();
            }
            else if (this.combo_type.Text == "Mountain Bike")
            {
                addMountainBike();
            }
            else
            {
                addElectricBike();
            }

        }

        //########################################################
        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.groupBox_add.Controls)
            {

                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            this.combo_type.Focus();
            this.listBox1.Items.Clear();
        }

        //########################################################

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = this.listBox1.SelectedIndex;
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (index != -1 && listOfBikes.Count != 0)
            {
                this.listOfBikes[index].Serial_number = Convert.ToInt64(this.tbox_serialNumber.Text);
                this.listOfBikes[index].SpeedUp(Convert.ToDouble(this.tbox_speed.Text));
                MessageBox.Show("​Serial Number and Speed updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_print_Click(sender, e);
            }
            else 
            {
                MessageBox.Show("List is empty or you did not select an item yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //########################################################
        private void btn_search_Click(object sender, EventArgs e)
        {
            bool found = false;

            double userSearch_temp = Convert.ToDouble(this.tbox_search.Text);

            foreach (Bike item in listOfBikes)
            {
                if (item.Serial_number == userSearch_temp)
                {
                    found = true;
                    MessageBox.Show(item.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Not Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //########################################################
        private void btn_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you");
            this.Close();
        }

        //########################################################
        private void combo_type_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.combo_type.Text == "Road Bike")
            {
                this.tbox_heightFromGround.Enabled = true;
                this.combo_suspension.Enabled = true;
                this.tbox_seatHeight.Enabled = false;
                this.tbox_seatHeight.Text = "";
                this.tbox_tireSize.Text = "";
                this.tbox_tireSize.Enabled = false;
                this.combo_abs.Enabled = true;
                this.combo_charge.Enabled = false;
                this.combo_range.Enabled = false;
            }
            else if (this.combo_type.Text == "Mountain Bike")
            {

                this.tbox_heightFromGround.Enabled = false;
                this.combo_suspension.Enabled = false;
                this.tbox_seatHeight.Enabled = true;
                this.tbox_heightFromGround.Text = "";
                this.combo_abs.Enabled = false;
                this.tbox_tireSize.Enabled = true;
                this.combo_charge.Enabled = false;
                this.combo_range.Enabled = false;
            }
            else
            {

                this.tbox_heightFromGround.Enabled = false;
                this.combo_suspension.Enabled = false;
                this.tbox_seatHeight.Enabled = false;
                this.tbox_heightFromGround.Text = "";
                this.tbox_seatHeight.Text = "";
                this.tbox_tireSize.Text = "";
                this.combo_abs.Enabled = false;
                this.tbox_tireSize.Enabled = false;
                this.combo_charge.Enabled = true;
                this.combo_range.Enabled = true;
            }
        }

        //########################################################
        private void btn_print_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            if (listOfBikes.Count == 0)
            {
                MessageBox.Show("The List is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int i = 1;

                foreach (Bike item in listOfBikes)
                {
                    this.listBox1.Items.Add(i + "- " + item.ToString());
                    i++;
                }
            }

        }

        //########################################################
        private void btn_printRoadBikes_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();


            if (listOfBikes.Count == 0)
            {
                MessageBox.Show("The List is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 1;

                foreach (Bike item in listOfBikes)
                {

                    if (item is RoadBike)
                    {
                        this.listBox1.Items.Add(i + "- " + item.ToString());
                        i++;
                    }

                }
            }

        }

        private void btn_printMountainBikes_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();


            if (listOfBikes.Count == 0)
            {
                MessageBox.Show("The List is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 1;

                foreach (Bike item in listOfBikes)
                {

                    if (item is MountainBike)
                    {
                        this.listBox1.Items.Add(i + "- " + item.ToString());
                        i++;
                    }

                }
            }

        }

        //When using read / write, press print again to update list...

        private void btn_writeBin_Click(object sender, EventArgs e)
        {

            FileHandler.WriteToSerializedFile(listOfBikes);
        }

        private void btn_readBin_Click(object sender, EventArgs e)
        {

            this.listOfBikes = FileHandler.ReadFromSerializedFile();

        }

        private void combo_range_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_charge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //if you add more bikes to the list and press "read binary" 
        //it will show the list that was previously saved


        //END########################################################
    }
}
