using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;

namespace 個体値カウンター
{
    public class Pokemon : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        private int _HP, _攻撃, _防御, _特攻, _特防, _素早さ;
        public string HP { get; set; }
        public string 攻撃 { get; set; }
        public string 防御 { get; set; }
        public string 特攻 { get; set; }
        public string 特防 { get; set; }
        public string 素早さ { get; set; }

        public bool きょうせいギブス { get; set; }
        public bool パワーウエイト { get; set; }
        public bool パワーリスト { get; set; }
        public bool パワーベルト { get; set; }
        public bool パワーレンズ { get; set; }
        public bool パワーバンド { get; set; }
        public bool パワーアンクル { get; set; }
        public bool ポケルス { get; set; }

        public Pokemon()
        {
            HP = "0";
            攻撃 = "0";
            防御 = "0";
            特攻 = "0";
            特防 = "0";
            素早さ = "0";
            ポケルス = true;
        }

        public void 能力値Plus(string propertyName, int n)
        {
            switch (propertyName)
            {
                case "HP":
                    try
                    {
                        _HP = int.Parse(HP);
                    }
                    catch (Exception)
                    {
                    }
                    _HP += (n + (パワーウエイト ? 4 : 0)) * (きょうせいギブス ? 2 : 1) * (ポケルス ? 2 : 1);
                    HP = _HP.ToString();
                    break;
                case "攻撃":
                    try
                    {
                        _攻撃 = int.Parse(攻撃);
                    }
                    catch (Exception)
                    {
                    }
                    _攻撃 += (n + (パワーリスト ? 4 : 0)) * (きょうせいギブス ? 2 : 1) * (ポケルス ? 2 : 1);
                    攻撃 = _攻撃.ToString();
                    break;
                case "防御":
                    try
                    {
                        _防御 = int.Parse(防御);
                    }
                    catch (Exception)
                    {
                    }
                    _防御 += (n + (パワーベルト ? 4 : 0)) * (きょうせいギブス ? 2 : 1) * (ポケルス ? 2 : 1);
                    防御 = _防御.ToString();
                    break;
                case "特攻":
                    try
                    {
                        _特攻 = int.Parse(特攻);
                    }
                    catch (Exception)
                    {
                    }
                    _特攻 += (n + (パワーレンズ ? 4 : 0)) * (きょうせいギブス ? 2 : 1) * (ポケルス ? 2 : 1);
                    特攻 = _特攻.ToString();
                    break;
                case "特防":
                    try
                    {
                        _特防 = int.Parse(特防);
                    }
                    catch (Exception)
                    {
                    }
                    _特防 += (n + (パワーバンド ? 4 : 0)) * (きょうせいギブス ? 2 : 1) * (ポケルス ? 2 : 1);
                    特防 = _特防.ToString();
                    break;
                case "素早さ":
                    try
                    {
                        _素早さ = int.Parse(素早さ);
                    }
                    catch (Exception)
                    {
                    }
                    _素早さ += (n + (パワーアンクル ? 4 : 0)) * (きょうせいギブス ? 2 : 1) * (ポケルス ? 2 : 1);
                    素早さ = _素早さ.ToString();
                    break;
            }
            onProperyChanged(propertyName);
        }


        public void ドーピング(string propertyName, int n)
        {
            switch (propertyName)
            {
                case "HP":
                    try
                    {
                        _HP = int.Parse(HP);
                    }
                    catch (Exception)
                    {
                    }
                    if (_HP < 90)
                        _HP += n;
                    else if (_HP < 100)
                        _HP = 100;
                    HP = _HP.ToString();
                    break;
                case "攻撃":
                    try
                    {
                        _攻撃 = int.Parse(攻撃);
                    }
                    catch (Exception)
                    {
                    }
                    if (_攻撃 < 90)
                        _攻撃 += n;
                    else if (_攻撃 < 100)
                        _攻撃 = 100;
                    攻撃 = _攻撃.ToString();
                    break;
                case "防御":
                    try
                    {
                        _防御 = int.Parse(防御);
                    }
                    catch (Exception)
                    {
                    }
                    if (_防御 < 90)
                        _防御 += n;
                    else if (_防御 < 100)
                        _防御 = 100;
                    防御 = _防御.ToString();
                    break;
                case "特攻":
                    try
                    {
                        _特攻 = int.Parse(特攻);
                    }
                    catch (Exception)
                    {
                    }
                    if (_特攻 < 90)
                        _特攻 += n;
                    else if (_特攻 < 100)
                        _特攻 = 100;
                    特攻 = _特攻.ToString();
                    break;
                case "特防":
                    try
                    {
                        _特防 = int.Parse(特防);
                    }
                    catch (Exception)
                    {
                    }
                    if (_特防 < 90)
                        _特防 += n;
                    else if (_特防 < 100)
                        _特防 = 100;
                    特防 = _特防.ToString();
                    break;
                case "素早さ":
                    try
                    {
                        _素早さ = int.Parse(素早さ);
                    }
                    catch (Exception)
                    {
                    }
                    if (_素早さ < 90)
                        _素早さ += n;
                    else if (_素早さ < 100)
                        _素早さ = 100;
                    素早さ = _素早さ.ToString();
                    break;
            }
            onProperyChanged(propertyName);
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            List<string> errors = new List<string>();
            switch (propertyName)
            {
                case "HP":
                    try
                    {
                        _HP = int.Parse(HP);
                    }
                    catch (Exception)
                    {
                        errors.Add("数値が不正です。");
                    }
                    if (_HP < 0 || _HP > 255)
                    {
                        errors.Add("数値が範囲を超えています。");
                    }
                    break;
                case "攻撃":
                    try
                    {
                        _攻撃 = int.Parse(攻撃);
                    }
                    catch (Exception)
                    {
                        errors.Add("数値が不正です。");
                    }
                    if (_攻撃 < 0 || _攻撃 > 255)
                    {
                        errors.Add("数値が範囲を超えています。");
                    }
                    break;
                case "防御":
                    try
                    {
                        _防御 = int.Parse(防御);
                    }
                    catch (Exception)
                    {
                        errors.Add("数値が不正です。");
                    }
                    if (_防御 < 0 || _防御 > 255)
                    {
                        errors.Add("数値が範囲を超えています。");
                    }
                    break;
                case "特攻":
                    try
                    {
                        _特攻 = int.Parse(特攻);
                    }
                    catch (Exception)
                    {
                        errors.Add("数値が不正です。");
                    }
                    if (_特攻 < 0 || _特攻 > 255)
                    {
                        errors.Add("数値が範囲を超えています。");
                    }
                    break;
                case "特防":
                    try
                    {
                        _特防 = int.Parse(特防);
                    }
                    catch (Exception)
                    {
                        errors.Add("数値が不正です。");
                    }
                    if (_特防 < 0 || _特防 > 255)
                    {
                        errors.Add("数値が範囲を超えています。");
                    }
                    break;
                case "素早さ":
                    try
                    {
                        _素早さ = int.Parse(素早さ);
                    }
                    catch (Exception)
                    {
                        errors.Add("数値が不正です。");
                    }
                    if (_素早さ < 0 || _素早さ > 255)
                    {
                        errors.Add("数値が範囲を超えています。");
                    }
                    break;
            }
            return errors;
        }

        public bool HasErrors
        {
            get
            {
                try
                {
                    _HP = int.Parse(HP);
                    _攻撃 = int.Parse(攻撃);
                    _防御 = int.Parse(防御);
                    _特攻 = int.Parse(特攻);
                    _特防 = int.Parse(特防);
                    _素早さ = int.Parse(素早さ);
                    return _HP < 0 || _HP > 255 || _攻撃 < 0 || _攻撃 > 255 || _防御 < 0 || _防御 > 255 || _特攻 < 0 || _特攻 > 255 || _特防 < 0 || _特防 > 255 || _素早さ < 0 || _素早さ > 255;
                }
                catch (Exception)
                {
                    return true;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onProperyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
