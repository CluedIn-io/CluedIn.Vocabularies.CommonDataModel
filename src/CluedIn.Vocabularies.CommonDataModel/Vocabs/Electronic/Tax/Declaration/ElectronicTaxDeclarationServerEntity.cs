using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicTaxDeclarationServerEntityVocabulary : SimpleVocabulary
    {
        public ElectronicTaxDeclarationServerEntityVocabulary()
        {
            VocabularyName = "ElectronicTaxDeclarationServerEntity";
            KeyPrefix = "commonDataModel.electronictaxdeclarationserverentity";
            KeySeparator = ".";
            Grouping = "/ElectronicTaxDeclarationServerEntity";

            AddGroup("ElectronicTaxDeclarationServerEntity Details", group =>
            {
                InternetAddress = group.Add(new VocabularyKey(nameof(InternetAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InternetAddress { get; private set; }
        public VocabularyKey Company { get; private set; }


    }
}