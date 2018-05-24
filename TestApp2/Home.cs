// ***********************************************************************
// Assembly         : TestApp2
// Author           : Amos Chepchieng
// Created          : 05-15-2018
//
// Last Modified By : Amos Chepchieng
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="Home.cs" company="Bunifu Technologies">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp2
{
    /// <summary>
    /// Class Home.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Home : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        public Home()
        {
            InitializeComponent();
        }


        #region functions

        /// <summary>
        /// Adds from database.
        /// </summary>
        /// <param name="bunifuDropdown">The bunifu dropdown.</param>
        private void addFromDb(Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown)
        {
            try
            {
                bunifuDropdown1.Items.Clear();
                MySqlConnection con = new MySqlConnection("server=127.0.0.1;uid=root;password=;database=bunifu_tests;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT `gender` FROM `students` WHERE 1", con);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    bunifuDropdown.Items.Add(read.GetString(0));
                }
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Make sure a db exists" + er.Message);
            }
        }


        /// <summary>
        /// Adds from dictionary.
        /// </summary>
        private void addFromDictionary()
        {
            bunifuDropdown1.Items.Clear();
            SortedDictionary<string, string> userFullnames = new SortedDictionary<string, string>
            {
                {"John", "Doe"},
                {"Barrack", "Obama"},
                {"Amos", "Chepchieng"}
            };
            bunifuDropdown1.DataSource = new BindingSource(userFullnames, null);
            bunifuDropdown1.DisplayMember = "Key";
            bunifuDropdown1.ValueMember = "Value";
        }


        /// <summary>
        /// Adds from array.
        /// </summary>
        private void addFromArray()
        {
            bunifuDropdown1.Items.Clear();

            string[] items = { "A-Male", "A-Female", "A-Other" };

            foreach (var item in items)
            {
                bunifuDropdown1.Items.Add(item);
            }

            //or
            //bunifuDropdown1.DataSource = items;
        }


        /// <summary>
        /// Adds from list.
        /// </summary>
        private void addFromList()
        {

            bunifuDropdown1.Items.Clear();

            IList<string> items = new List<string>();
            items.Add("L-Male");
            items.Add("L-Female");
            items.Add("L-Other");
            foreach (var item in items)
            {
                bunifuDropdown1.Items.Add(item);
            }
            //or
            //bunifuDropdown1.DataSource = items;
        }

        /// <summary>
        /// Adds from model.
        /// </summary>
        private void addFromModel()

        {
            bunifuDropdown1.Items.Clear();
            var students = new List<Student>
        {
            new Student() { FirstName="Student1FirstName", LastName="Student1LastName"},
            new Student() { FirstName="Student2FirstName", LastName="Student2LastName"},
            new Student() { FirstName="Student3FirstName", LastName="Student3LastName"}
        };

            foreach (Student student in students)
            {
                bunifuDropdown1.Items.Add(student.FirstName + "  " + student.LastName);

            }
            //or
            //bunifuDropdown1.DataSource = students;
        }

        #endregion


        #region events

        /// <summary>
        /// Handles the Click event of the btn_db control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_db_Click(object sender, EventArgs e)
        {
            addFromDb(bunifuDropdown1);
        }

        /// <summary>
        /// Handles the Click event of the btn_array control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_array_Click(object sender, EventArgs e)
        {
            addFromArray();
        }

        /// <summary>
        /// Handles the Click event of the btn_list control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_list_Click(object sender, EventArgs e)
        {
            addFromList();
        }

        /// <summary>
        /// Handles the Click event of the btn_dictionary control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_dictionary_Click(object sender, EventArgs e)
        {
            addFromDictionary();
        }

        /// <summary>
        /// Handles the Click event of the btn_model control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_model_Click(object sender, EventArgs e)
        {
            addFromModel();
        }

        #endregion

        #region classes
        //sample model class

        /// <summary>
        /// Class Student.
        /// </summary>
        public class Student
        {
            /// <summary>
            /// Gets or sets the first name.
            /// </summary>
            /// <value>The first name.</value>
            public string FirstName { get; set; }
            /// <summary>
            /// Gets or sets the last name.
            /// </summary>
            /// <value>The last name.</value>
            public string LastName { get; set; }
        }

        #endregion
    }
}