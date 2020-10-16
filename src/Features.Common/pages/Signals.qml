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
            text: "Signals can be declared in .NET. Signals can be raised from .NET or Qml."
        }

        Button {
            text: 'Raise from .NET'
            onClicked: {
                model.raiseSignal()
            }
        }
        
        Button {
            text: 'Raise from Qml.'
            onClicked: {
                model.customSignal('Signal was raised from Qml at ' + new Date())
            }
        }
        
        Text {
            id: message
        }
        
        SignalsModel {
            id: model
            onCustomSignal: function(result) {
                message.text = result
            }
        }
    }
}
