import QtQuick 2.6
import QtQuick.Controls 2.1
import Features 1.0

ScrollablePage {
    Column {
        Label { text: qsTr("Input") }

        Grid {
            id: inputContainer
            columns: 2
            spacing: 12
            width: parent.width
        
            TextField { 
                id: txtValue1
                placeholderText: qsTr("Value 1")

                onEditingFinished: {
                        inputContainer.validateInput()
                }
            }
            TextField { 
                id: txtValue2
                placeholderText: qsTr("Value 2")

                onEditingFinished: {
                        inputContainer.validateInput()
                }
            }

            Label { 
                id: lblValidation
                color: 'red'
            }

            function validateInput() {
                var fieldsFilled = txtValue1.text !== "" && txtValue2.text !== ""
                if (!fieldsFilled) {
                        model.isValid = false
                        lblValidation.text = ''
                        return
                }
                
                model.isValid = !isNaN(txtValue1.text) && !isNaN(txtValue2.text)
                if (!model.isValid) {
                        lblValidation.text = qsTr("Input value(s) is/are invalid.")
                }
                else  {
                        lblValidation.text = ''
                }
            }
        }

        Label { text: qsTr("Operations") }

        Grid {
            id: operationsContainer
            columns: 4
            spacing: 12
            width: parent.width

            Button {
                text: "+"
                onClicked: {
                    if (model.isValid) {
                        model.add(txtValue1.text, txtValue2.text)
                    }
                }
            }

            Button {
                text: "-"
                onClicked: {
                    if (model.isValid) {
                        model.subtract(txtValue1.text, txtValue2.text)
                    }
                }
            }

            Button {
                text: "x"
                onClicked: {
                    if (model.isValid) {
                        model.multiply(txtValue1.text, txtValue2.text)
                    }
                }
            }

            Button { 
                text: ":"
                onClicked: {
                    if (model.isValid) {
                        model.divide(txtValue1.text, txtValue2.text)
                    }
                }
            }
        }

        Label {
            text: model.computedResult
            color: 'green'
        }

        CalculatorModel {
            id: model
        }
    }
}
