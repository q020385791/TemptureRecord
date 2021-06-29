﻿using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemptureRecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int NameIndex = 0;
        private void btnsign_Click(object sender, EventArgs e)
        {
            //google Form select dropdown

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("");
            Thread.Sleep(2000);
            //下拉選單主框
            By selectXPath = By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[1]/div/div/div[2]/div/div[1]");
            //點擊主框
            var test2 = driver.FindElement(selectXPath);test2.Click();
            
            //等待js修正
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[1]/div/div/div[2]/div/div[2]/div[" + NameIndex + "]/span")));
            //選取項目
            driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[1]/div/div/div[2]/div/div[2]/div["+ NameIndex + "]/span")).Click();

            Thread.Sleep(1000);
            //填入輸入框
            driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[1]/input")).SendKeys(txtTempture.Text);


            //提交
            driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[3]/div[1]/div/div")).Click();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HtmlWeb webClient = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = webClient.Load("https://docs.google.com/forms/d/e/1FAIpQLSeadohuf0YBVSGZDVPi89uPbsAxvHdCbh6kXb8Q2C-juru0Pw/viewform");

            ////姓名
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//*[@id='mG61Hd']/div[2]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div");
            foreach (var item in nodes)
            {
                cblistName.Items.Add(item.InnerText);
            }
           
        }

        private void cblistName_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameIndex = cblistName.SelectedIndex+1;
        }
    }
}
