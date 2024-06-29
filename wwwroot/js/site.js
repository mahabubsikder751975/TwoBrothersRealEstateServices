// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function saveCustomerInfo() {
    const firstName = document.getElementById('firstName').value;
    const middleName = document.getElementById('middleName').value;
    const lastName = document.getElementById('lastName').value;
    const address = document.getElementById('address').value;
    const email = document.getElementById('email').value;
    const phone = document.getElementById('phone').value;
    const query = document.getElementById('query').value;

    const customerInfo = `
        First Name: ${firstName}
        Middle Name: ${middleName}
        Last Name: ${lastName}
        Address: ${address}
        Email ID: ${email}
        Phone Number: ${phone}
        Query/Messages: ${query}
    `;

    const blob = new Blob([customerInfo], { type: 'text/plain' });
    const anchor = document.createElement('a');
    anchor.href = URL.createObjectURL(blob);
    anchor.download = 'customer_info.txt';
    anchor.click();

    // Clear form after submission
    document.getElementById('customerForm').reset();
}

