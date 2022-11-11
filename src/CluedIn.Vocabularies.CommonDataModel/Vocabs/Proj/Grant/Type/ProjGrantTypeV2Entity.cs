using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjGrantTypeV2EntityVocabulary : SimpleVocabulary
    {
        public ProjGrantTypeV2EntityVocabulary()
        {
            VocabularyName = "ProjGrantTypeV2Entity";
            KeyPrefix = "commonDataModel.projgranttypev2entity";
            KeySeparator = ".";
            Grouping = "/ProjGrantTypeV2Entity";

            AddGroup("ProjGrantTypeV2Entity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FederalMandate = group.Add(new VocabularyKey(nameof(FederalMandate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantManager = group.Add(new VocabularyKey(nameof(GrantManager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantType = group.Add(new VocabularyKey(nameof(GrantType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumber = group.Add(new VocabularyKey(nameof(OrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateMandate = group.Add(new VocabularyKey(nameof(StateMandate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubGrantor = group.Add(new VocabularyKey(nameof(SubGrantor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerContact = group.Add(new VocabularyKey(nameof(WorkerContact), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludeFromSEFA = group.Add(new VocabularyKey(nameof(ExcludeFromSEFA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManagerPersonnelNumber = group.Add(new VocabularyKey(nameof(ManagerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonnelNumber = group.Add(new VocabularyKey(nameof(ContactPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey FederalMandate { get; private set; }
        public VocabularyKey GrantManager { get; private set; }
        public VocabularyKey GrantType { get; private set; }
        public VocabularyKey OrganizationNumber { get; private set; }
        public VocabularyKey StateMandate { get; private set; }
        public VocabularyKey SubGrantor { get; private set; }
        public VocabularyKey WorkerContact { get; private set; }
        public VocabularyKey ExcludeFromSEFA { get; private set; }
        public VocabularyKey ManagerPersonnelNumber { get; private set; }
        public VocabularyKey ContactPersonnelNumber { get; private set; }


    }
}