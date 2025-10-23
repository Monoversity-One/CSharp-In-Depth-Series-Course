#region

using System.Linq;
using System.Windows.Forms;
using BasicInventoryManager.MyClass.Part;
using BasicInventoryManager.MyClass.PartSell;
using BasicInventoryManager.MyClass.Seller;

#endregion

namespace BasicInventoryManager
{
    public partial class FrmPartSellInfo : Form
    {
        private readonly Part _part;
        private readonly PartSell _partSell;
        private readonly Seller _seller;

        public FrmPartSellInfo()
        {
            _seller = new Seller();
            _partSell = new PartSell();
            _part = new Part();
        }

        public FrmPartSellInfo(string partSellId, string partId, string sellerCode)
        {
            InitializeComponent();


            // To retrieve sale information

            _partSell = PartsSell.AllPartsSell.Find(d => d.PartSellId == partSellId);

            lblPartSellId.Text = _partSell.PartSellId;
            lblPartId.Text = _partSell.PartId;
            lblSellerCode.Text = _partSell.SellerCode;


            // end

            // To retrieve part information

            _part = Parts.AllParts.Find(d => d.Id == partId);
            lblPartName.Text = _part.Name;
            lblPartPrice.Text = _part.Price;


            // end

            // To retrieve seller information

            _seller = Sellers.AllSellers.Find(d => d.Code == sellerCode);
            lblSellerName.Text = _seller.Name;
            lblSellerFamily.Text = _seller.Family;

            // end


            // To retrieve overall information

            lblPartSellCount.Text = PartsSell.AllPartsSell.Count(d => d.PartId == _part.Id).ToString();

            lblPartSellTotamOfType.Text = (from ps in PartsSell.AllPartsSell
                                           join p in Parts.AllParts on ps.PartId equals p.Id
                                           where ps.PartId == _part.Id
                                           select int.Parse(p.Price)).Sum().ToString();

            lblTotalPartOfSeller.Text = PartsSell.AllPartsSell.Count(d => d.SellerCode == _seller.Code).ToString();

            // end
        }
    }
}