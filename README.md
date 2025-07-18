# CST8917 Lab 3: Implementing a Teams Chat Content Moderation Service

## 📸 Demo Video

🎥 Watch the demo here:  
**[▶️ YouTube Video Link](https://youtu.be/ke40vtXDjCM)**

---
## 🛠️ Prerequisites
- ✅ Azure subscription with appropriate permissions  
- ✅ Microsoft Teams access
- ✅ Basic understanding of Azure services
- ✅ [Visual Studio Code](https://code.visualstudio.com/) + Azure Functions extension  

### Azure Logic Apps

Azure Logic Apps is a cloud-based service that allows you to automate workflows and integrate services without writing much code. It is ideal for building real-time systems triggered by services like Microsoft Teams, email, or HTTP endpoints.


## Tasks

## 🔵 **1. Design the Moderation Workflow**

<img width="624" height="624" alt="image" src="https://github.com/user-attachments/assets/91d81af1-5c43-433a-bb9d-7bd28ac5fd39" />

---

## 🔧 2. Building the Moderation Service Involves:

### 📁 1. Setting Up Azure Infrastructure

- ✅ **Resource Group** (to organize resources)
  - **name:** `teams-moderation-lab`
    
- ✅ **Logic App** (main workflow engine)
   - **name:** `teams-content-moderation`
     
- ✅ **Azure Function App** (for custom logic)
  - **name:** `teams-moderation-functions2`
    
- ✅ **Cognitive Services** (for AI-powered content analysis) (Language service)
  - **name:** `teams-language-service`
<img width="191" height="185" alt="Screenshot 2025-07-17 conn3" src="https://github.com/user-attachments/assets/cb86fef1-fcd5-48bc-a7a7-6d4b54b367a0" />


### 📁 2. Integrating with Microsoft Teams

- 📡 **Create an Incoming Webhook** to receive messages from a Teams channel
    **Name:** `Content Moderation Webhook`  
    Webhook URL:  
    `https://algonquinlivecom.webhook.office.com/webhookb2/0fe7e6eb-470e-4b1b-8510-576962945c5b@ec1bd924-0a6a-4aa9-aa89-c980316c0449/IncomingWebhook/9660f9fc258c4a4a88e85c02131b59b5/e472f014-89f6-4887-b288-fadf45714780/V27Em6gOhWejIwrqbvi6FwkDQcwRT6H7pY4HyH0MWCXSY1`


<p align="left">
  <img width="328" height="333" alt="Webhook Name" src="https://github.com/user-attachments/assets/17d08c65-ca37-4b30-bd80-7f2a341ab28d" />
</p>

- 📡 **Register an Azure AD App** (if you want to call Microsoft Graph API)
  #### 2.1 Register Application in Azure AD

  #### 2.2 Configure API Permissions  
    ```bash
    az ad sp create --id 69b32b88-a39a-45a1-8f06-7921866333b0
    ````

  #### 2.3 Create Client Secret
    `b143aefe-b514-4940-90b7-5330b5c2dc8c`
<img width="535" height="358" alt="image" src="https://github.com/user-attachments/assets/b949f709-d825-40ea-beeb-22c24f85c34e" />

---

### 🧱 3. Creating the Moderation Workflow

<img width="335" height="458" alt="image" src="https://github.com/user-attachments/assets/05f5b2ac-6573-43af-86e5-81da6e01a414"/>

### ⚙️ 1 **Logic App** is triggered when a Teams message is posted

<img width="565" height="657" alt="image" src="https://github.com/user-attachments/assets/32c2f990-fe68-47e3-98a1-8a03201e907b" />


### 🧠 2 **Azure Function** or **Cognitive Service** analyzes the message content
<img width="466" height="458" alt="Screenshot 2025-07-17 Languagekeys" src="https://github.com/user-attachments/assets/92f6c72b-0aea-476a-96ad-06046bfef303" />

### 💬 3 📧 **send an alert** (e.g., via email)
  


  
---
 




