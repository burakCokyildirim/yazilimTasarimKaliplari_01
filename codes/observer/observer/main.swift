//
//  main.swift
//  observer
//
//  Created by Burak Çokyıldırım on 13.05.2020.
//  Copyright © 2020 burak. All rights reserved.
//


import Foundation

class Main {
    func main() {
        let subject = USBManager()

        let observer1 = USBObserver(subject: subject)
        let observer2 = USBObserver(subject: subject)


        subject.changeUSBState(usbType: .usbA)
        subject.changeUSBState(usbType: .usbC)

        subject.unregister(observer: observer2)

        subject.changeUSBState(usbType: .usbB)
        
        subject.unregister(observer: observer1)
    }
}

let main = Main()
main.main()

