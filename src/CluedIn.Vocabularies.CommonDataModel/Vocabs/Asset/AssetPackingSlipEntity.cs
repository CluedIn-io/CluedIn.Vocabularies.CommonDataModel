using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetPackingSlipEntityVocabulary : SimpleVocabulary
    {
        public AssetPackingSlipEntityVocabulary()
        {
            VocabularyName = "AssetPackingSlipEntity";
            KeyPrefix = "commonDataModel.assetpackingslipentity";
            KeySeparator = ".";
            Grouping = "/AssetPackingSlipEntity";

            AddGroup("AssetPackingSlipEntity Details", group =>
            {
                PackingSlip = group.Add(new VocabularyKey(nameof(PackingSlip), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateTime = group.Add(new VocabularyKey(nameof(CreateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateDate = group.Add(new VocabularyKey(nameof(CreateDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewDepartment = group.Add(new VocabularyKey(nameof(NewDepartment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalDepartment = group.Add(new VocabularyKey(nameof(OriginalDepartment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintTransportationDetails = group.Add(new VocabularyKey(nameof(PrintTransportationDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GoodsIssuedBy = group.Add(new VocabularyKey(nameof(GoodsIssuedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Package = group.Add(new VocabularyKey(nameof(Package), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskLevelOfTheLoad = group.Add(new VocabularyKey(nameof(RiskLevelOfTheLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierType = group.Add(new VocabularyKey(nameof(CarrierType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Carrier = group.Add(new VocabularyKey(nameof(Carrier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDateAndTime = group.Add(new VocabularyKey(nameof(DocumentDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Model = group.Add(new VocabularyKey(nameof(Model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrailerRegistrationNumber = group.Add(new VocabularyKey(nameof(TrailerRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Driver = group.Add(new VocabularyKey(nameof(Driver), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DriverName = group.Add(new VocabularyKey(nameof(DriverName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingDateAndTime = group.Add(new VocabularyKey(nameof(LoadingDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingName = group.Add(new VocabularyKey(nameof(LoadingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingAddress = group.Add(new VocabularyKey(nameof(LoadingAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadAddress = group.Add(new VocabularyKey(nameof(LoadAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingDateAndTime = group.Add(new VocabularyKey(nameof(UnloadingDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingName = group.Add(new VocabularyKey(nameof(UnloadingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingAddress = group.Add(new VocabularyKey(nameof(UnloadingAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadAddress = group.Add(new VocabularyKey(nameof(UnloadAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PackingSlip { get; private set; }
        public VocabularyKey CreateTime { get; private set; }
        public VocabularyKey CreateDate { get; private set; }
        public VocabularyKey NewDepartment { get; private set; }
        public VocabularyKey OriginalDepartment { get; private set; }
        public VocabularyKey PrintTransportationDetails { get; private set; }
        public VocabularyKey GoodsIssuedBy { get; private set; }
        public VocabularyKey Package { get; private set; }
        public VocabularyKey RiskLevelOfTheLoad { get; private set; }
        public VocabularyKey CarrierType { get; private set; }
        public VocabularyKey Carrier { get; private set; }
        public VocabularyKey DocumentDateAndTime { get; private set; }
        public VocabularyKey Model { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey TrailerRegistrationNumber { get; private set; }
        public VocabularyKey Driver { get; private set; }
        public VocabularyKey DriverName { get; private set; }
        public VocabularyKey LoadingDateAndTime { get; private set; }
        public VocabularyKey LoadingName { get; private set; }
        public VocabularyKey LoadingAddress { get; private set; }
        public VocabularyKey LoadAddress { get; private set; }
        public VocabularyKey UnloadingDateAndTime { get; private set; }
        public VocabularyKey UnloadingName { get; private set; }
        public VocabularyKey UnloadingAddress { get; private set; }
        public VocabularyKey UnloadAddress { get; private set; }
        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}