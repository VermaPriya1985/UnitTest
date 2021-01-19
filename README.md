<div class="Box-body px-5 pb-5">
<article class="markdown-body entry-content container-lg" itemprop="text"><h2><a id="user-content-gardenit" class="anchor" aria-hidden="true" href="#gardenit"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Calculate Funds</h2>
<p> This Application calculates balance of Customer Account Numbers by depositing and withdrawing funds between different accounts.Deposits and withdraws can be made in Canadian dollars, US dollars or Mexican Pesos. The applicable exchange rate is applied when depositing or withdrawing a foreign currency. Exchange Rates are
$1.00 CAD = $0.50 USD, $1.00 CAD = $10.00 MXN. This application is built using C# and XUnit testing framework is used to test this application. There are 5 different cases:  </p>

<h2><a id="user-content-components" class="anchor" aria-hidden="true" href="#components"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Cases:</h2>

<h3><a id="user-content-engine" class="anchor" aria-hidden="true" href="#engine"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Case 1: </h3>
<p> Input: Customer: Stewie Griffin Customer ID: 777 Account Number: 1234 Initial Balance for account number 1234: $100.00 CAD
Stewie Griffin deposits $300.00 USD to account number 1234 </p>
<p> Output: Account Number: 1234 Balance: $700.00 CAD</p>

<h3><a id="user-content-engine" class="anchor" aria-hidden="true" href="#engine"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Case 2: </h3>
<p> Input: Customer: Glenn Quagmire Customer ID: 504 Account Number: 2001 Initial balance for account number 2001: $35,000.00 CAD
Glenn Quagmire withdraws $5,000.00 MXN from account number 2001. Glenn Quagmire withdraws $12,500.00 USD from account number 2001. Glenn Quagmire deposits $300.00 CAD to account number 2001 </p>
<p> Output: Account Number: 2001 Balance: $9,800 CAD</p>

<h3><a id="user-content-engine" class="anchor" aria-hidden="true" href="#engine"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Case 3: </h3>
<p> Input: Customer: Joe Swanson Customer ID: 002
Account Number: 1010 Initial balance for account number 1010: $7,425.00 CAD
Customer: Joe Swanson Customer ID: 002 Account Number: 5500 Initial balance for account number 5500: $15,000.00 CAD
Joe Swanson withdraws $5,000.00 CAD from account number 5500. Joe Swanson transfers $7,300.00 CAD from account number 1010 to account number 5500. Joe Swanson deposits $13,726.00 MXN to account number 1010. </p>
<p> Output: Account Number: 1010 Balance: $1,497.60 CAD Account Number: 5500 Balance: $17,300.00 CAD</p>

<h3><a id="user-content-engine" class="anchor" aria-hidden="true" href="#engine"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Case 4: </h3>
<p> Input: Customer: Peter Griffin Customer ID: 123 Account Number: 0123 Initial balance for account number 0123: $150.00 CAD
Customer: Lois Griffin Customer ID: 456 Account Number: 0456 Initial balance for account number 0456: $65,000.00 CAD
Peter Griffin withdraws $70.00 USD from account number 0123. Lois Griffin deposits $23,789.00 USD to account number 0456. Lois Griffin transfers $23.75 CAD from account number 0456 to Peter Griffin (account number 0123). </p>
<p> Output: Account Number: 0123 Balance: $33.75 CAD Account Number: 0456 Balance: $112,554.25 CAD</p>

<h3><a id="user-content-engine" class="anchor" aria-hidden="true" href="#engine"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Case 5: </h3>
<p> Input: Customer: Joe Swanson Customer ID: 002 Account Number: 1010 Initial balance for account number 1010: $7,425.00 CAD
Famous social engineer and thief John Shark (Customer ID 219) attempts to withdraw $100 USD from account 1010. The bank determines that the account is not John’s and refuses to give him the money. </p>
<p> Account Number: 1010 Balance: $7,425.00 CAD</p>





