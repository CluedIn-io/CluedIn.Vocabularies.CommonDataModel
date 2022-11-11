using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdComEntityVocabulary : SimpleVocabulary
    {
        public ProdComEntityVocabulary()
        {
            VocabularyName = "ProdComEntity";
            KeyPrefix = "commonDataModel.prodcomentity";
            KeySeparator = ".";
            Grouping = "/ProdComEntity";

            AddGroup("ProdComEntity Details", group =>
            {
                Period = group.Add(new VocabularyKey(nameof(Period), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Section1 = group.Add(new VocabularyKey(nameof(Section1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Section2 = group.Add(new VocabularyKey(nameof(Section2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Section3 = group.Add(new VocabularyKey(nameof(Section3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Section4 = group.Add(new VocabularyKey(nameof(Section4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Field13 = group.Add(new VocabularyKey(nameof(Field13), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Field14 = group.Add(new VocabularyKey(nameof(Field14), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BranchNumber = group.Add(new VocabularyKey(nameof(BranchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnA = group.Add(new VocabularyKey(nameof(ColumnA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnC = group.Add(new VocabularyKey(nameof(ColumnC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnD = group.Add(new VocabularyKey(nameof(ColumnD), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnE = group.Add(new VocabularyKey(nameof(ColumnE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnF = group.Add(new VocabularyKey(nameof(ColumnF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnG = group.Add(new VocabularyKey(nameof(ColumnG), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnH = group.Add(new VocabularyKey(nameof(ColumnH), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnI = group.Add(new VocabularyKey(nameof(ColumnI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnJ = group.Add(new VocabularyKey(nameof(ColumnJ), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnK = group.Add(new VocabularyKey(nameof(ColumnK), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnL = group.Add(new VocabularyKey(nameof(ColumnL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnM = group.Add(new VocabularyKey(nameof(ColumnM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnN = group.Add(new VocabularyKey(nameof(ColumnN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnO = group.Add(new VocabularyKey(nameof(ColumnO), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesId = group.Add(new VocabularyKey(nameof(SalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesName = group.Add(new VocabularyKey(nameof(SalesName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OtherDelivery = group.Add(new VocabularyKey(nameof(OtherDelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreationWork = group.Add(new VocabularyKey(nameof(CreationWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityHierarchyName = group.Add(new VocabularyKey(nameof(CommodityHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityName = group.Add(new VocabularyKey(nameof(CommodityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitId = group.Add(new VocabularyKey(nameof(UnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQty = group.Add(new VocabularyKey(nameof(SalesQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Period { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Section1 { get; private set; }
        public VocabularyKey Section2 { get; private set; }
        public VocabularyKey Section3 { get; private set; }
        public VocabularyKey Section4 { get; private set; }
        public VocabularyKey Field13 { get; private set; }
        public VocabularyKey Field14 { get; private set; }
        public VocabularyKey BranchNumber { get; private set; }
        public VocabularyKey ColumnA { get; private set; }
        public VocabularyKey ColumnC { get; private set; }
        public VocabularyKey ColumnD { get; private set; }
        public VocabularyKey ColumnE { get; private set; }
        public VocabularyKey ColumnF { get; private set; }
        public VocabularyKey ColumnG { get; private set; }
        public VocabularyKey ColumnH { get; private set; }
        public VocabularyKey ColumnI { get; private set; }
        public VocabularyKey ColumnJ { get; private set; }
        public VocabularyKey ColumnK { get; private set; }
        public VocabularyKey ColumnL { get; private set; }
        public VocabularyKey ColumnM { get; private set; }
        public VocabularyKey ColumnN { get; private set; }
        public VocabularyKey ColumnO { get; private set; }
        public VocabularyKey CustAccount { get; private set; }
        public VocabularyKey SalesId { get; private set; }
        public VocabularyKey SalesName { get; private set; }
        public VocabularyKey OtherDelivery { get; private set; }
        public VocabularyKey CreationWork { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey CommodityHierarchyName { get; private set; }
        public VocabularyKey CommodityName { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey UnitId { get; private set; }
        public VocabularyKey SalesQty { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }


    }
}