namespace ORUSCURSO.Presentacion.Reportes
{
    partial class ReportAsistencia
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup7 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.tblReporteAsistenciaPersonal = new Telerik.Reporting.Table();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox23 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // textBox6
            // 
            this.textBox6.Format = "{0:d}";
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.41D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox6.Value = "=Fields.Fecha";
            // 
            // textBox18
            // 
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.746D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox18.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox18.StyleName = "";
            this.textBox18.Value = "=Fields.Nombres";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.2D);
            this.detail.Name = "detail";
            // 
            // tblReporteAsistenciaPersonal
            // 
            this.tblReporteAsistenciaPersonal.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.41D)));
            this.tblReporteAsistenciaPersonal.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(1.3D)));
            this.tblReporteAsistenciaPersonal.Body.SetCellContent(0, 0, this.textBox7);
            tableGroup2.Name = "tableGroup2";
            tableGroup2.ReportItem = this.textBox6;
            tableGroup1.ChildGroups.Add(tableGroup2);
            tableGroup1.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.Dia"));
            tableGroup1.Name = "dia";
            tableGroup1.ReportItem = this.textBox3;
            tableGroup1.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.Dia", Telerik.Reporting.SortDirection.Asc));
            this.tblReporteAsistenciaPersonal.ColumnGroups.Add(tableGroup1);
            this.tblReporteAsistenciaPersonal.Corner.SetCellContent(1, 0, this.textBox19);
            this.tblReporteAsistenciaPersonal.Corner.SetCellContent(1, 1, this.textBox21);
            this.tblReporteAsistenciaPersonal.Corner.SetCellContent(1, 2, this.textBox5);
            this.tblReporteAsistenciaPersonal.Corner.SetCellContent(1, 3, this.textBox2);
            this.tblReporteAsistenciaPersonal.Corner.SetCellContent(0, 0, this.textBox16);
            this.tblReporteAsistenciaPersonal.Corner.SetCellContent(0, 1, this.textBox17);
            this.tblReporteAsistenciaPersonal.Corner.SetCellContent(0, 2, this.textBox22);
            this.tblReporteAsistenciaPersonal.Corner.SetCellContent(0, 3, this.textBox23);
            this.tblReporteAsistenciaPersonal.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox19,
            this.textBox21,
            this.textBox5,
            this.textBox2,
            this.textBox7,
            this.textBox18,
            this.textBox20,
            this.textBox4,
            this.textBox15,
            this.textBox6,
            this.textBox3,
            this.textBox16,
            this.textBox17,
            this.textBox22,
            this.textBox23});
            this.tblReporteAsistenciaPersonal.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.tblReporteAsistenciaPersonal.Name = "tblReporteAsistenciaPersonal";
            tableGroup7.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup7.Name = "detailTableGroup";
            tableGroup6.ChildGroups.Add(tableGroup7);
            tableGroup6.Name = "group1";
            tableGroup6.ReportItem = this.textBox15;
            tableGroup5.ChildGroups.Add(tableGroup6);
            tableGroup5.Name = "group2";
            tableGroup5.ReportItem = this.textBox4;
            tableGroup4.ChildGroups.Add(tableGroup5);
            tableGroup4.Name = "group3";
            tableGroup4.ReportItem = this.textBox20;
            tableGroup3.ChildGroups.Add(tableGroup4);
            tableGroup3.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.Nombres"));
            tableGroup3.Name = "nombres";
            tableGroup3.ReportItem = this.textBox18;
            tableGroup3.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.Nombres", Telerik.Reporting.SortDirection.Asc));
            this.tblReporteAsistenciaPersonal.RowGroups.Add(tableGroup3);
            this.tblReporteAsistenciaPersonal.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(13.156D), Telerik.Reporting.Drawing.Unit.Cm(3.1D));
            // 
            // textBox7
            // 
            this.textBox7.Format = "{0:N2}";
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.41D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox7.Value = "=Sum(Fields.Horas)";
            // 
            // textBox19
            // 
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.746D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox19.StyleName = "";
            this.textBox19.Value = "Nombres";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.2D);
            this.pageFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox8});
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox8.Style.Font.Bold = false;
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox8.Value = "Reporte Generado por INDEX365";
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox9,
            this.textBox10,
            this.textBox11,
            this.textBox12,
            this.textBox13,
            this.textBox14});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.1D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox1.Value = "Reporte de Asistencia de Personal";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(1.9D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox9.Value = "Desde:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.9D), Telerik.Reporting.Drawing.Unit.Cm(1.9D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox10.Value = "=Fields.Desde";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.266D), Telerik.Reporting.Drawing.Unit.Cm(1.9D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox11.Value = "Hasta:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.199D), Telerik.Reporting.Drawing.Unit.Cm(1.9D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox12.Value = "=Fields.Hasta";
            // 
            // textBox13
            // 
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.6D), Telerik.Reporting.Drawing.Unit.Cm(1.9D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox13.Value = "# Semana:";
            // 
            // textBox14
            // 
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.9D), Telerik.Reporting.Drawing.Unit.Cm(1.9D));
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox14.Value = "=Fields.Semana";
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3.4D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.tblReporteAsistenciaPersonal});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            // 
            // textBox21
            // 
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox21.Value = "Total Horas";
            // 
            // textBox20
            // 
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox20.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox20.Value = "=Sum(Fields.Horas)";
            // 
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox5.Value = "Valor por Hora";
            // 
            // textBox4
            // 
            this.textBox4.Format = "{0:N2}";
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox4.Value = "=Fields.SueldoPorHora";
            // 
            // textBox2
            // 
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox2.StyleName = "";
            this.textBox2.Value = "Total Bruto";
            // 
            // textBox15
            // 
            this.textBox15.Format = "{0:N2}";
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox15.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox15.StyleName = "";
            this.textBox15.Value = "=(Fields.SueldoPorHora)*(Fields.Horas)";
            // 
            // textBox3
            // 
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.41D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox3.StyleName = "";
            this.textBox3.Value = "=Fields.Dia";
            // 
            // textBox16
            // 
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.746D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox16.StyleName = "";
            // 
            // textBox17
            // 
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox17.StyleName = "";
            // 
            // textBox22
            // 
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox22.StyleName = "";
            // 
            // textBox23
            // 
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox23.StyleName = "";
            // 
            // ReportAsistencia
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1,
            this.reportHeaderSection1});
            this.Name = "ReportAsistencia";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.Font.Name = "Consolas";
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(22.1D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox8;
        public Telerik.Reporting.Table tblReporteAsistenciaPersonal;
        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.TextBox textBox14;
        private Telerik.Reporting.ReportHeaderSection reportHeaderSection1;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox15;
    }
}