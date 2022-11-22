using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using Vermaat.Crm.Specflow.Entities;

namespace Vermaat.Crm.Specflow.Connectivity
{
    public interface ICrmService: IOrganizationService
    {
        Guid CallerId { get; set; }
        Guid UserId { get; }
        UserSettings UserSettings { get; }
        void Create(Entity entity, string alias, AliasedRecordCache recordCache);
        void Delete(EntityReference entityReference);
        T Execute<T>(OrganizationRequest request) where T : OrganizationResponse;
        Guid GetUserId();
        UserSettings GetUserSettings();
        Entity Retrieve(EntityReference entityReference, ColumnSet columnSet);
    }
}