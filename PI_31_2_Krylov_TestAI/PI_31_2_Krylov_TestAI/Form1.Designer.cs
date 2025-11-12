
namespace PI_31_2_Krylov_TestAI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.numericUpDown_NecessaryOutput = new System.Windows.Forms.NumericUpDown();
            this.SaveTrainSample = new System.Windows.Forms.Button();
            this.SaveTestSample = new System.Windows.Forms.Button();
            this.recognizebutton = new System.Windows.Forms.Button();
            this.label_output = new System.Windows.Forms.Label();
            this.label_Probability = new System.Windows.Forms.Label();
            this.button_Training = new System.Windows.Forms.Button();
            this.chart_Eavr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NecessaryOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Eavr)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(89, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(48, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(48, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(89, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(7, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(48, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(89, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(7, 153);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 35);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(48, 194);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 35);
            this.button10.TabIndex = 11;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(89, 194);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 35);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(7, 194);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 35);
            this.button12.TabIndex = 9;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(48, 235);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 35);
            this.button13.TabIndex = 14;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(89, 235);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 35);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(7, 235);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 35);
            this.button15.TabIndex = 12;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Changing_State_Pixel_Button_Click);
            // 
            // numericUpDown_NecessaryOutput
            // 
            this.numericUpDown_NecessaryOutput.Location = new System.Drawing.Point(7, 276);
            this.numericUpDown_NecessaryOutput.Name = "numericUpDown_NecessaryOutput";
            this.numericUpDown_NecessaryOutput.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_NecessaryOutput.TabIndex = 15;
            // 
            // SaveTrainSample
            // 
            this.SaveTrainSample.Location = new System.Drawing.Point(7, 304);
            this.SaveTrainSample.Name = "SaveTrainSample";
            this.SaveTrainSample.Size = new System.Drawing.Size(117, 46);
            this.SaveTrainSample.TabIndex = 16;
            this.SaveTrainSample.Text = "Save Train Sample";
            this.SaveTrainSample.UseVisualStyleBackColor = true;
            this.SaveTrainSample.Click += new System.EventHandler(this.button_SaveSample_Click);
            // 
            // SaveTestSample
            // 
            this.SaveTestSample.Location = new System.Drawing.Point(7, 356);
            this.SaveTestSample.Name = "SaveTestSample";
            this.SaveTestSample.Size = new System.Drawing.Size(117, 46);
            this.SaveTestSample.TabIndex = 17;
            this.SaveTestSample.Text = "Save Test Sample";
            this.SaveTestSample.UseVisualStyleBackColor = true;
            this.SaveTestSample.Click += new System.EventHandler(this.button_SaveSample_Click);
            // 
            // recognizebutton
            // 
            this.recognizebutton.Location = new System.Drawing.Point(130, 71);
            this.recognizebutton.Name = "recognizebutton";
            this.recognizebutton.Size = new System.Drawing.Size(77, 35);
            this.recognizebutton.TabIndex = 18;
            this.recognizebutton.Text = "Распознать";
            this.recognizebutton.UseVisualStyleBackColor = true;
            this.recognizebutton.Click += new System.EventHandler(this.recongnizebutton_Click);
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_output.Location = new System.Drawing.Point(12, 9);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(71, 39);
            this.label_output.TabIndex = 19;
            this.label_output.Text = "Out";
            this.label_output.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Probability
            // 
            this.label_Probability.AutoSize = true;
            this.label_Probability.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Probability.Location = new System.Drawing.Point(89, 14);
            this.label_Probability.Name = "label_Probability";
            this.label_Probability.Size = new System.Drawing.Size(184, 32);
            this.label_Probability.TabIndex = 20;
            this.label_Probability.Text = "Вероятность";
            // 
            // button_Training
            // 
            this.button_Training.Location = new System.Drawing.Point(130, 112);
            this.button_Training.Name = "button_Training";
            this.button_Training.Size = new System.Drawing.Size(77, 35);
            this.button_Training.TabIndex = 21;
            this.button_Training.Text = "Обучить";
            this.button_Training.UseVisualStyleBackColor = true;
            this.button_Training.Click += new System.EventHandler(this.button_Training_Click);
            // 
            // chart_Eavr
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Eavr.ChartAreas.Add(chartArea1);
            this.chart_Eavr.Location = new System.Drawing.Point(242, 69);
            this.chart_Eavr.Name = "chart_Eavr";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart_Eavr.Series.Add(series1);
            this.chart_Eavr.Size = new System.Drawing.Size(619, 333);
            this.chart_Eavr.TabIndex = 22;
            this.chart_Eavr.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График средних энергий ошибок";
            this.chart_Eavr.Titles.Add(title1);
            this.chart_Eavr.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 459);
            this.Controls.Add(this.chart_Eavr);
            this.Controls.Add(this.button_Training);
            this.Controls.Add(this.label_Probability);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.recognizebutton);
            this.Controls.Add(this.SaveTestSample);
            this.Controls.Add(this.SaveTrainSample);
            this.Controls.Add(this.numericUpDown_NecessaryOutput);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NecessaryOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Eavr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.NumericUpDown numericUpDown_NecessaryOutput;
        private System.Windows.Forms.Button SaveTrainSample;
        private System.Windows.Forms.Button SaveTestSample;
        private System.Windows.Forms.Button recognizebutton;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Label label_Probability;
        private System.Windows.Forms.Button button_Training;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Eavr;
    }
}

