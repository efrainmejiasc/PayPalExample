

/*$(document).ready(function () {
    CreateScriptPaypal();
});


function CreateScriptPaypal() {
    var head = document.getElementsByTagName('head')[0];
    var script = document.createElement('script');
    script.src = "https://www.paypal.com/sdk/js?client-id=AXw6feF6vXkFM3chrCgVsIvjZyidI1DH3uymVqbjBoH1na7oMM90v9sjLadl8g0nLl2lXe1FoKSuoczh&disable-funding=credit,card,bancontact&currency=BRL&intent=capture&integration-date=2020-08-05&locale=es_CO";
    head.appendChild(script);
    setTimeout(RenderButton, 2000,56.76,'paquete');
}

function RenderButton(purchaseAmount,purchaseType) {

    paypal.Buttons({
        createOrder: function (data, actions) {
            // This function sets up the details of the transaction, including the amount and line item details.
            return actions.order.create({
                purchase_units: [{
                    amount: {
                        value: purchaseAmount
                    }
                }]
            });
        },
        onApprove: function (data, actions) {
            // This function captures the funds from the transaction.
            return actions.order.capture().then(function (details) {
                // This function shows a transaction success message to your buyer.
                console.log(details);
                console.log(data);
                if (details.status === 'COMPLETED')
                    PaypalResponse(data,purchaseType);
                else
                    alert('ERROR EN PAGO');
            });
        }
    }).render('#paypal-button-container');
  //This function displays Smart Payment Buttons on your web page.
}


function PaypalResponse (model,purchaseType) {
    $.ajax({
        type: "POST",
        url: "/Processor/PaypalResponse",
        data: { model: model, purchaseType: purchaseType},
        datatype: "json",
        success: function (data) {
            console.log('PAYPAL_DONE');
        },
        complete: function () {
            console.log('PAYPAL_RESPONSE');
        }
    });
    return false;
}

function PaypalResponse2(model) {
    var url = "/Processor/PaypalResponse";
    fetch(url, {
        method: 'POST',
        body: JSON.stringify(model),
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(res => res.json())
        .catch(error => console.error('Error:', error))
        .then(response => console.log('Success:', response));
}

function Testing(url) {
    window.location = url;
}

function WriteConsole(value) {
    console.log(value);
}*/

function Redirecto() {
    $.ajax({
        type: "GET",
        url: "/Home/Redirecto",
        data: { _ref: 'test'},
        datatype: "json",
        success: function (data) {
            console.log(data);
            window.location.href = data.Referencia;
        },
        complete: function () {
            console.log('RedirecTo');
        }
    });
    return false;
}