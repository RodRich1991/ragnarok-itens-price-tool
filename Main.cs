using Arkaik_Monster_Json_Enchancer;
using System.Xml.Linq;

namespace RagnarokItensPriceTool
{
    public partial class Main : Form
    {
        private ItemData _itemData;
        private ConverterService _Service;
        private string _nomeOriginal;

        public Main()
        {
            InitializeComponent();

            nud_percent.ValueChanged += (a, b) => ValidateState();
            rb_PercentMinus.CheckedChanged += (a, b) => ValidateState();
            rb_PercentPlus.CheckedChanged += (a, b) => ValidateState();
            chb_ChangeBuy.CheckedChanged += (a, b) => ValidateState();
            chb_ChangeSell.CheckedChanged += (a, b) => ValidateState();
        }

        private ConverterService Converter()
        {
            if (_Service == null)
                _Service = new ConverterService();

            return _Service;
        }

        private void ValidateState()
        {
            btn_Start.Enabled = (_itemData?.Body?.Any() ?? false) 
                && (chb_ChangeBuy.Checked || chb_ChangeSell.Checked); // pelo menos uma checkbox marcada
        }

        private void Btn_FilePath_Click(object sender, EventArgs e)
        {
            string itemPath = PickFile();
            Txb_FilePath.Text = itemPath;
            _nomeOriginal = string.IsNullOrEmpty(itemPath) ? "" : Path.GetFileName(itemPath);
            _itemData = Converter().ExtractObjectYaml(itemPath);
            ValidateState();
        }

        private string PickFile()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = $"Item file|*.yml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            return null;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            decimal percent = nud_percent.Value;
            bool isSubtract = rb_PercentMinus.Checked;
            bool adjustBuy = chb_ChangeBuy.Checked;
            bool adjustSell = chb_ChangeSell.Checked;

            _itemData.Body.ForEach(item =>
            {
                if (item.Buy == null && item.Sell == null)
                    return;

                if (item.Buy == null && adjustBuy)
                    item.Buy = item.Sell * 2;

                if (item.Sell == null && adjustSell)
                    item.Sell = item.Buy / 2;

                if (adjustBuy)
                    item.Buy = AdjustValue(isSubtract, percent, item.Buy.Value);

                if (adjustSell)
                    item.Sell = AdjustValue(isSubtract, percent, item.Sell.Value);
            });

            SalvarOutput();
        }

        private void SalvarOutput()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivo YAML (*.yml)|*.yml", // Define o filtro de extensão do arquivo
                Title = $"Salvar Item db",
                FileName = _nomeOriginal
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    Converter().SaveToYamlFile(filePath, _itemData);
                    MessageBox.Show("Arquivo salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show($"Falha ao tentar escrever {filePath}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btn_Start.Enabled = false;
            }
        }

        private int AdjustValue(bool isSubtract, decimal percent, int value)
        {
            decimal adjustment = (percent * 0.01m) * value;
            return isSubtract
                ? value - (int)Math.Round(adjustment)
                : value + (int)Math.Round(adjustment);
        }
    }
}
