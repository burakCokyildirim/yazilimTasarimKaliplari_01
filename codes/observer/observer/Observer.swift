//
//  Observer.swift
//  observer
//
//  Created by Burak Çokyıldırım on 13.05.2020.
//  Copyright © 2020 burak. All rights reserved.
//

import Foundation

protocol Observer: class {

    func update(usbA: Bool, usbB: Bool, usbC: Bool)
}
