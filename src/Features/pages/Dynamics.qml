import QtQuick 2.6
import QtQuick.Controls 2.1
import Features 1.0

ScrollablePage {

    Column {
        spacing: 40
        width: parent.width

        Label {
            width: parent.width
            wrapMode: Label.Wrap
            horizontalAlignment: Qt.AlignHCenter
            text: 'Mutable JS objects can be sent to .NET to be interacted with, using the ""dynamic"" type'
        }

        Button {
            text: 'Send JS delegate to be invoked from .NET'
            onClicked: {
                model.invokeJavascriptFunction(function(result) {
                    message.text = result
                }, 'Hello ! ' + new Date())
            }
        }
        
        Button {
            text: 'Perform math with raw JS objects.'
            onClicked: {
                var source = {
                    value1: 54,
                    value2: 36
                }
                var result = {
                }
                model.add(source, result)
                message.text = 'Result: ' + result.computedResult
            }
        }
        
        Text {
            id: message
        }
        
        DynamicModel {
            id: model
        }
    }
}
