
var SibApiV3Sdk = require('sib-api-v3-sdk');
var defaultClient = SibApiV3Sdk.ApiClient.instance;

var apiKey = defaultClient.authentications['api-key'];
apiKey.apiKey = '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';
var apiInstance = new SibApiV3Sdk.EmailCampaignsApi();
var emailCampaigns = new SibApiV3Sdk.CreateEmailCampaign();

emailCampaigns.name = "Campaign sent via the API";
emailCampaigns.subject = "My subject";
emailCampaigns.sender = {"name": "From name", "email":"roheemlateef.3@gmail.com"};
emailCampaigns.type = "classic";

htmlContent: 'Congratulations! You successfully sent this example campaign via the Brevo API.',

 {listIds: [2, 7]},

apiInstance.createEmailCampaign(emailCampaigns).then(function(data) {
console.log('API called successfully. Returned data: ' + data);
}, function(error) {
console.error(error);
});





// var SibApiV3Sdk = require('sib-api-v3-sdk');
// var defaultClient = SibApiV3Sdk.ApiClient.instance;

// var apiKey = defaultClient.authentications['api-key'];
// apiKey.apiKey = 'YOUR_API_V3_KEY';
// var apiInstance = new SibApiV3Sdk.EmailCampaignsApi();
// var emailCampaigns = new SibApiV3Sdk.CreateEmailCampaign();

// emailCampaigns.name = "Campaign sent via the API";
// emailCampaigns.subject = "My subject";
// emailCampaigns.sender = {"name": "From name", "email":"myfromemail@mycompany.com"};
// emailCampaigns.type = "classic";

// htmlContent: 'Congratulations! You successfully sent this example campaign via the Brevo API.',

// {listIds: [2, 7]}

// scheduledAt: '2018-01-01 00:00:01'

// apiInstance.createEmailCampaign(emailCampaigns).then(function(data) {
// console.log('API called successfully. Returned data: ' + data);
// }, function(error) {
// console.error(error);
// });