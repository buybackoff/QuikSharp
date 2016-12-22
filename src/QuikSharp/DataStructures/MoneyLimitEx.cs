// Copyright (C) 2015 Victor Baybekov
using Newtonsoft.Json;

namespace QuikSharp.DataStructures
{
    /// <summary>
    /// ������ �� �������� ���������
    /// </summary>
    public class MoneyLimitEx {
        // ReSharper disable InconsistentNaming
        /// <summary>
        /// �������� ����� �� �������� ���������
        /// </summary>
        [JsonProperty("money_open_limit")]
        public double MoneyOpenLimit { get; set; }

        /// <summary>
        /// ��������� �������������� ����� � ������� �� �������
        /// </summary>
        [JsonProperty("money_open_limit")]
        public double MoneyLimitLockedNonmarginalValue { get; set; }
        /// <summary>
        /// ��������������� � ������� �� ������� ���������� �������� �������
        /// </summary>
        [JsonProperty("money_open_limit")]
        public double MoneyLimitLocked { get; set; }
        /// <summary>
        /// �������� ������� �� �������� ���������
        /// </summary>
        [JsonProperty("money_open_limit")]
        public double MoneyOpenBalance { get; set; }
        /// <summary>
        /// ������� ����� �� �������� ���������
        /// </summary>
        [JsonProperty("money_open_limit")]
        public double MoneyCurrentLimit { get; set; }
        /// <summary>
        /// ������� ������� �� �������� ���������
        /// </summary>
        [JsonProperty("money_open_limit")]
        public double MoneyCurrentBalance { get; set; }
        /// <summary>
        /// ��������� ���������� �������� �������
        /// </summary>
        [JsonProperty("money_open_limit")]
        public double MoneyLimitAvailable { get; set; }

        /// <summary>
        /// ��� ������
        /// </summary>
        [JsonProperty("currcode")]
        public string CurrCode { get; set; }
        /// <summary>
        /// ��� ��������
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }
        /// <summary>
        /// ������������� �����
        /// </summary>
        [JsonProperty("firmid")]
        public string FirmId { get; set; }
        /// <summary>
        /// ��� �������
        /// </summary>
        [JsonProperty("client_code")]
        public string ClientCode { get; set; }
        /// <summary>
        /// �������� ������� �� �������
        /// </summary>
        [JsonProperty("openbal")]
        public double OpenBal { get; set; }
        /// <summary>
        /// �������� ����� �� �������
        /// </summary>
        [JsonProperty("openlimit")]
        public double OpenLimit { get; set; }
        /// <summary>
        /// ������� ������� �� �������
        /// </summary>
        [JsonProperty("currentbal")]
        public double CurrentBal { get; set; }
        /// <summary>
        /// ������� ����� �� �������
        /// </summary>
        [JsonProperty("currentlimit")]
        public double CurrentLimit { get; set; }
        /// <summary>
        /// ��������������� ����������
        /// </summary>
        [JsonProperty("locked")]
        public double Locked { get; set; }
        /// <summary>
        /// ��������� ������� � ������� �� ������� �������������� �����
        /// </summary>
        [JsonProperty("locked_value_coef")]
        public double LockedValueCoef { get; set; }
        /// <summary>
        /// ��������� ������� � ������� �� ������� ������������ �����
        /// </summary>
        [JsonProperty("locked_margin_value")]
        public double LockedMarginValue { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        [JsonProperty("leverage")]
        public double Leverage { get; set; }
        /// <summary>
        /// ��� ������. ��������� ��������:
        /// �0� � ������� ������,
        /// ����� � ��������������� ������
        /// </summary>
        [JsonProperty("limit_kind")]
        public double LimitKind { get; set; }
        // ReSharper restore InconsistentNaming
    }
}