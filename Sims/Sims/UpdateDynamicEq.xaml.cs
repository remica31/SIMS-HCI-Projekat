﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sims
{
    /// <summary>
    /// Interaction logic for UpdateDynamicEq.xaml
    /// </summary>
    public partial class UpdateDynamicEq : Window
    {
        public UpdateDynamicEq()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            WardenFunctional d = new WardenFunctional();
            this.Close();
            d.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Model.FileStorageRoom storage = new Model.FileStorageRoom();
            storage.Read1();
            storage.updateEquipment1(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            storage.write1();
            WardenFunctional d = new WardenFunctional();
            this.Close();
            d.Show();
        }
    }
}