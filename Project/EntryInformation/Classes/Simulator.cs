﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntryInformation;
using System.Drawing;


public class Simulator
{
    private Grid grid;
    private Simulation simulation;

    public Simulator(Simulation simulation)
    {
        grid = new Grid();
        this.simulation = simulation;
    }

    public void calculatePanelSize(int nrOfRows, int nrOfColumns, Panel gridPanel, GroupBox gridGroupBox)
    {

        int height = nrOfRows * 200;
        int width = nrOfColumns * 200;

        gridPanel.Size = new Size(width, height);
        gridGroupBox.Size = new Size(width + 15, height + 30);
    }

    public void DrawGrid(ComboBox comboBoxRows, ComboBox comboBoxColumns, Panel gridPanel, GroupBox gridGroupBox)
    {
        int nrOfRows = Convert.ToInt16(comboBoxRows.SelectedItem);
        int nrOfColumns = Convert.ToInt16(comboBoxColumns.SelectedItem);

        calculatePanelSize(nrOfRows, nrOfColumns, gridPanel, gridGroupBox);
        System.Drawing.Pen myPen;
        myPen = new System.Drawing.Pen(System.Drawing.Color.White);
        System.Drawing.Graphics formGraphics = gridPanel.CreateGraphics();

        //drawing cells rows
        foreach (var item in grid.ReturnGridCells(nrOfRows, nrOfColumns))
        {
            formGraphics.DrawLine(myPen, item.ReturnLocation().X, item.ReturnLocation().Y, (item.ReturnLocation().X + 200), item.ReturnLocation().Y);//top line from the left to right
            formGraphics.DrawLine(myPen, item.ReturnLocation().X, item.ReturnLocation().Y, item.ReturnLocation().X, (item.ReturnLocation().Y + 200));//left line from top to bottom
            formGraphics.DrawLine(myPen, item.ReturnLocation().X, (item.ReturnLocation().Y + 199), (item.ReturnLocation().X + 200), item.ReturnLocation().Y + 199);//bottom line from the left to right
            formGraphics.DrawLine(myPen, (item.ReturnLocation().X + 199), item.ReturnLocation().Y, (item.ReturnLocation().X + 199), (item.ReturnLocation().Y + 200));//right line from top to bottom
        }
        //if (Convert.ToInt16(comboBoxRows.SelectedItem) == 3 || Convert.ToInt16(comboBoxColumns.SelectedItem) == 4)
        //{
        //    formGraphics.DrawLine(myPen, 0, 600, 800, 600);
        //    formGraphics.DrawLine(myPen, 800, 0, 800, 800);
        //}

        myPen.Dispose();
        formGraphics.Dispose();
    }
    public void miki()
    {
        
    }


    public List<Crossing> crossings
    {
        get;
        set;
    }

    public DateTime Time
    {
        get;
        set;
    }

    public virtual List<Cars> CarsList
    {
        get;
        set;
    }

    public virtual Grid Grid
    {
        get;
        set;
    }

    public virtual Form Form
    {
        get;
        set;
    }

    public virtual IEnumerable<Cars> Cars
    {
        get;
        set;
    }

    public virtual void Run()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Save()
    {
        throw new System.NotImplementedException();
    }

}

