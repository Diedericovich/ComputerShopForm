﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormProductInfo : Form
    {
        private readonly IProductsRepo _repo;
        public List<IProduct> _productinfolist;

        public FormProductInfo(IProduct product)
        {
            InitializeComponent();
            this.Text = product.Name;
            _repo = new ProductsRepo();
            _productinfolist = _repo.CreateProductList();
            SetData(product);
        }

        public void SetData(IProduct product)
        {
            AddComputerInfo(product);
            AddTypeInfo(product);
            txtboxInfo.Text = product.ToString();
        }

        public void AddComputerInfo(IProduct product)
        {
            var computer = product as Computer;
            pictureBoxProductInfo.Load(computer.ProductImagePath);
            txtBoxName.Text = computer.Name;
            txtBoxRam.Text = Convert.ToString(computer.Ram);
            txtBoxMoBo.Text = computer.MoBo;
            txtBoxPsu.Text = computer.PSU;
            txtBoxCpu.Text = computer.CPU;
            txtBoxHdd.Text = computer.HDD;
            txtBoxStock.Text = Convert.ToString(computer.Stock);
            txtBoxPrice.Text = Convert.ToString(product.Price);
            txtBoxDescription.Text = product.ProductSummary;
            txtBoxId.Text = Convert.ToString(product.Id);
        }

        public void AddTypeInfo(IProduct product)
        {
            if (product is GamingPc)
            {
                var temp = product as GamingPc;
            }
            else if (product is Workstation)
            {
                var temp = product as Workstation;
            }
            else if (product is Laptop)
            {
                var temp = product as Laptop;
                txtBoxScreenType.Text = temp.ScreenType;
                txtBoxWeight.Text = $"{Convert.ToString(temp.WeightInGrams)} grams";
            }
        }
    }
}