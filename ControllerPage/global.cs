using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerPage
{
    static class Global
    {
        private static string _globalVar = "";
        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
        private static string _globalVar1 = "Current Interval Moisture Measurement";
        public static string GlobalVar1
        {
            get { return _globalVar1; }
            set { _globalVar1 = value; }
        }
        private static string _globalVar2 = "Interval Number";
        public static string GlobalVar2
        {
            get { return _globalVar2; }
            set { _globalVar2 = value; }
        }
        private static string _globalVar3 = "Kernel Counter";
        public static string GlobalVar3
        {
            get { return _globalVar3; }
            set { _globalVar3 = value; }
        }
        private static string _globalVar4 = "Average Moisture";
        public static string GlobalVar4
        {
            get { return _globalVar4; }
            set { _globalVar4 = value; }
        }
        private static string _globalVar5 = "Product";
        public static string GlobalVar5
        {
            get { return _globalVar5; }
            set { _globalVar5 = value; }
        }
        private static string _globalVar6 = "No. of Intervals";
        public static string GlobalVar6
        {
            get { return _globalVar6; }
            set { _globalVar6 = value; }
        }
        private static string _globalVar7 = "PCS per Interval";
        public static string GlobalVar7
        {
            get { return _globalVar7; }
            set { _globalVar7 = value; }
        }
        private static string _globalVar8 = "Int. Waiting Time";
        public static string GlobalVar8
        {
            get { return _globalVar8; }
            set { _globalVar8 = value; }
        }
        private static string _globalVar9 = "Options";
        public static string GlobalVar9
        {
            get { return _globalVar9; }
            set { _globalVar9 = value; }
        }
        private static string _globalVar10 = "Sensor Number";
        public static string GlobalVar10
        {
            get { return _globalVar10; }
            set { _globalVar10 = value; }
        }
        private static string _globalVar11 = "Status";
        public static string GlobalVar11
        {
            get { return _globalVar11; }
            set { _globalVar11 = value; }
        }
        private static string _globalVar12 = "Temp";
        public static string GlobalVar12
        {
            get { return _globalVar12; }
            set { _globalVar12 = value; }
        }
        private static string _globalVar13 = "Interface";
        public static string GlobalVar13
        {
            get { return _globalVar13; }
            set { _globalVar13 = value; }
        }
        private static string _globalVar14 = "Mode";
        public static string GlobalVar14
        {
            get { return _globalVar14; }
            set { _globalVar14 = value; }
        }
        private static string _globalVar15 = "Threshold Max";
        public static string GlobalVar15
        {
            get { return _globalVar15; }
            set { _globalVar15 = value; }
        }
        private static string _globalVar16 = "Threshold Min";
        public static string GlobalVar16
        {
            get { return _globalVar16; }
            set { _globalVar16 = value; }
        }
        private static string _globalVar17 = "Offline";
        public static string GlobalVar17
        {
            get { return _globalVar17; }
            set { _globalVar17 = value; }
        }
        private static string _globalVar18 = "Paddy";
        public static string GlobalVar18
        {
            get { return _globalVar18; }
            set { _globalVar18 = value; }
        }
        private static int _globalVar19 = 0;
        public static int GlobalVar19
        {
            get { return _globalVar19; }
            set { _globalVar19 = value; }
        }

        private static int _globalVar20 = 0;
        public static int GlobalVar20
        {
            get { return _globalVar20; }
            set { _globalVar20 = value; }
        }

        private static string _globalVar21 = "00:00";
        public static string GlobalVar21
        {
            get { return _globalVar21; }
            set { _globalVar21 = value; }
        }

        private static bool _globalVar22 = false;
        public static bool GlobalVar22
        {
            get { return _globalVar22; }
            set { _globalVar22 = value; }
        }
        private static float m_0 = 0;
        public static float m0
        {
            get { return m_0; }
            set { m_0 = value; }
        }

        private static float m_1 = 0;
        public static float m1
        {
            get { return m_1; }
            set { m_1 = value; }
        }

        private static float m_2 = 0;
        public static float m2
        {
            get { return m_2; }
            set { m_2 = value; }
        }

        private static float m_3 = 0;
        public static float m3
        {
            get { return m_3; }
            set { m_3 = value; }
        }

        private static int _numpcs = 100;
        // private static int _numpcs = 10;
        public static int numpcs
        {
            get { return _numpcs; }
            set { _numpcs = value; }
        }
        private static int _waitinginterval = 180000;
        // private static int _waitinginterval = 30000;
        public static int waitinginterval
        {
            get { return _waitinginterval; }
            set { _waitinginterval = value; }
        }
        private static int _numofinterval = 3;
        // private static int _numofinterval = 1;
        public static int numofinterval
        {
            get { return _numofinterval; }
            set { _numofinterval = value; }
        }
        private static int _count = 1;
        public static int count
        {
            get { return _count; }
            set { _count = value; }
        }

        private static float _lowinterval = 0;
        public static float lowinterval
        {
            get { return _lowinterval; }
            set { _lowinterval = value; }
        }

        private static float _lowpcs = 0;
        public static float lowpcs
        {
            get { return _lowpcs; }
            set { _lowpcs = value; }
        }

        private static float _mediuminterval = 0;
        public static float mediuminterval
        {
            get { return _mediuminterval; }
            set { _mediuminterval = value; }
        }
        private static float _mediumpcs = 0;
        public static float mediumpcs
        {
            get { return _mediumpcs; }
            set { _mediumpcs = value; }
        }

        private static float _highinterval = 0;
        public static float highinterval
        {
            get { return _highinterval; }
            set { _highinterval = value; }
        }
        private static float _highpcs = 0;
        public static float highpcs
        {
            get { return _highpcs; }
            set { _highpcs = value; }
        }


    }
}
