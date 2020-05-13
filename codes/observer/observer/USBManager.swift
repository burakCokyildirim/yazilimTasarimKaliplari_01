//
//  USBManager.swift
//  observer
//
//  Created by Burak Çokyıldırım on 13.05.2020.
//  Copyright © 2020 burak. All rights reserved.
//

import Foundation

class USBManager: Subject {

    var isConnect_usbA = false
    var isConnect_usbB = false
    var isConnect_usbC = false

    private lazy var observers = [Observer]()

    func register(observer: Observer) {
        observers.append(observer)
        print("USBManager: Bir observer eklendi.\n")
    }

    func unregister(observer: Observer) {
        if let idx = observers.firstIndex(where: { $0 === observer }) {
            observers.remove(at: idx)
            print("USBManager: Bir observer silindi.\n")
        }
    }

    func notify() {
        print("USBManager: notify\n")
        observers.forEach({ $0.update(usbA: isConnect_usbA, usbB: isConnect_usbB, usbC: isConnect_usbC)})
    }

    func changeUSBState(usbType: USBTypes) {
        
        switch usbType {
        case .usbA:
            isConnect_usbA = !isConnect_usbA
        case .usbB:
            isConnect_usbB = !isConnect_usbB
        case .usbC:
            isConnect_usbC = !isConnect_usbC
        }
        notify()
    }
}
