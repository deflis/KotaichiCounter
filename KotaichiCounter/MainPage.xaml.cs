using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace 個体値カウンター
{
    public partial class MainPage : UserControl
    {
        Pokemon pokemon = new Pokemon();
        public MainPage()
        {
            InitializeComponent();

            this.DataContext = pokemon;
        }

        #region HP
        private void HPplus0(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("HP", 0);
        }

        private void HPplus1(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("HP", 1);
        }

        private void HPplus2(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("HP", 2);
        }

        private void HPplus3(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("HP", 3);
        }

        private void HPドーピング(object sender, RoutedEventArgs e)
        {
            pokemon.ドーピング("HP", 10);
        }
        #endregion

        #region 攻撃
        private void 攻撃plus0(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("攻撃", 0);
        }

        private void 攻撃plus1(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("攻撃", 1);
        }

        private void 攻撃plus2(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("攻撃", 2);
        }

        private void 攻撃plus3(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("攻撃", 3);
        }

        private void 攻撃ドーピング(object sender, RoutedEventArgs e)
        {
            pokemon.ドーピング("攻撃", 10);
        }
        #endregion

        #region 防御
        private void 防御plus0(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("防御", 0);
        }

        private void 防御plus1(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("防御", 1);
        }

        private void 防御plus2(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("防御", 2);
        }

        private void 防御plus3(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("防御", 3);
        }

        private void 防御ドーピング(object sender, RoutedEventArgs e)
        {
            pokemon.ドーピング("防御", 10);
        }
        #endregion

        #region 特攻
        private void 特攻plus0(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("特攻", 0);
        }

        private void 特攻plus1(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("特攻", 1);
        }

        private void 特攻plus2(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("特攻", 2);
        }

        private void 特攻plus3(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("特攻", 3);
        }

        private void 特攻ドーピング(object sender, RoutedEventArgs e)
        {
            pokemon.ドーピング("特攻", 10);
        }
        #endregion

        #region 特防
        private void 特防plus0(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("特防", 0);
        }

        private void 特防plus1(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("特防", 1);
        }

        private void 特防plus2(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("特防", 2);
        }

        private void 特防plus3(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("特防", 3);
        }

        private void 特防ドーピング(object sender, RoutedEventArgs e)
        {
            pokemon.ドーピング("特防", 10);
        }
        #endregion

        #region 素早さ
        private void 素早さplus0(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("素早さ", 0);
        }

        private void 素早さplus1(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("素早さ", 1);
        }

        private void 素早さplus2(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("素早さ", 2);
        }

        private void 素早さplus3(object sender, RoutedEventArgs e)
        {
            pokemon.能力値Plus("素早さ", 3);
        }

        private void 素早さドーピング(object sender, RoutedEventArgs e)
        {
            pokemon.ドーピング("素早さ", 10);
        }
        #endregion


    }
}
